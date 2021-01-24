using FluentAssertions;
using MarsRovers.Business;
using MarsRovers.Core;
using Microsoft.Extensions.DependencyInjection;
using TechTalk.SpecFlow;

namespace MarsRovers.Tests.Steps
{
    [Binding, Scope(Feature = "Rovers")]
    public sealed class Rovers
    {
        private readonly ScenarioContext _scenarioContext;

        public Rovers(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            var services = new ServiceCollection();
            services.AddLogging();
            services.AddTransient<IRoverOperator, RoverOperator>();
            services.AddTransient<ICommandService, CommandService>();

            _scenarioContext.Set(services);
            _scenarioContext.Set(services.BuildServiceProvider());
        }

        [Given(@"a plateau (.*)")]
        public void GivenAPlateau(string plateauCommandLine)
        {
            var commandService = _scenarioContext.Get<ServiceProvider>().GetService<ICommandService>();

            var (xBorder, yBorder) = commandService.GetPlateauParameters(plateauCommandLine);
            var plateau = new Plateau(xBorder, yBorder);

            _scenarioContext.Set(plateau);
        }

        [Given(@"a rover")]
        public void GivenARover()
        {
            var rover = new Rover();
            _scenarioContext.Set(rover);
        }

        [Given(@"the rover deployed to (.*)")]
        public void GivenTheRoverDeployed(string roverPosition)
        {
            var commandService = _scenarioContext.Get<ServiceProvider>().GetService<ICommandService>();
            var rover = _scenarioContext.Get<Rover>();

            var (xCoordinate, yCoordinate, direction) = commandService.GetRoverParameters(roverPosition);
            rover.DeployRover(xCoordinate, yCoordinate, direction);
        }

        [Given(@"(.*) command is send")]
        [Then(@"(.*) command is send")]
        public void WhenCommandIsSend(string roverCommands)
        {
            var commandService = _scenarioContext.Get<ServiceProvider>().GetService<ICommandService>();
            var rover = _scenarioContext.Get<Rover>();

            rover.Send(commandService.GetRoverCommands(roverCommands));
        }

        [When(@"commands are executed")]
        public void WhenCommandsAreExecuted()
        {
            var roverOperator = _scenarioContext.Get<ServiceProvider>().GetService<IRoverOperator>();
            var plateau = _scenarioContext.Get<Plateau>();
            var rover = _scenarioContext.Get<Rover>();

            roverOperator.SendEnvironment(plateau);
            roverOperator.ConnectTo(rover);

            foreach (var roverCommand in rover.Commands)
            {
                roverOperator.Execute(roverCommand);
            }
        }


        [Then(@"the rover should be at (.*)")]
        public void ThenTheRoverShouldBe(string locationCommand)
        {
            var commandService = _scenarioContext.Get<ServiceProvider>().GetService<ICommandService>();

            var (xCoordinate, yCoordinate, direction) = commandService.GetRoverParameters(locationCommand);

            var rover = _scenarioContext.Get<Rover>();

            rover.XCoordinate.Should().Be(xCoordinate);
            rover.YCoordinate.Should().Be(yCoordinate);
            rover.Direction.Should().Be(direction);
        }
    }
}
