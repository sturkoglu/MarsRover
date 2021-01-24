using System;
using System.Linq;
using MarsRovers.Business;
using MarsRovers.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace MarsRovers.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();

            RegisterDependencies(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger<Program>();

            logger.LogInformation("Starting application");

            Run(serviceProvider);

            logger.LogInformation("All done!");
        }


        private static void Run(IServiceProvider serviceProvider)
        {
            var logger = serviceProvider.GetService<ILogger<Program>>();
            var fileService = serviceProvider.GetService<IFileService>();
            var commandService = serviceProvider.GetService<ICommandService>();
            var roverOperator = serviceProvider.GetService<IRoverOperator>();

            var inputFileName = "input.txt";

            PrintInfo();

            var commandLines = fileService.ReadDocument(inputFileName);

            if (!commandLines.Any())
            {
                logger.LogError("Incorrect Input, please check the input file again");
                Console.WriteLine("No command found");
                Exit();
                return;
            }

            var plateau = commandService.GetPlateau(commandLines);
            var rovers = commandService.GetRovers(commandLines);

            if (plateau == null || !rovers.Any())
            {
                logger.LogError("Incorrect Input, please check the input file again");
                Console.WriteLine("Command is not valid");
                Exit();
                return;
            }

            roverOperator.Add(plateau);

            foreach (var rover in rovers)
            {
                roverOperator.Add(rover);
                roverOperator.Execute();

                var roverPosition = roverOperator.GetRoverPosition();
                Console.WriteLine($"Rover position; {roverPosition.xCoordinate} {roverPosition.yCoordinate} {roverPosition.direction}");
            }

            Exit();
        }

        private static void RegisterDependencies(IServiceCollection serviceCollection)
        {
            serviceCollection.AddLogging();
            serviceCollection.AddTransient<IFileService, FileService>();
            serviceCollection.AddTransient<ICommandService, CommandService>();
            serviceCollection.AddTransient<IRoverOperator, RoverOperator>();
        }

        private static void PrintInfo()
        {
            Console.WriteLine("Movement String");
            Console.WriteLine("M: move to next grid location");
            Console.WriteLine("L: turn left");
            Console.WriteLine("R: turn right");
            Console.WriteLine();
            Console.WriteLine("Example Cardano Command");
            Console.WriteLine("5 5");
            Console.WriteLine("1 2 N");
            Console.WriteLine("LML");

            Console.WriteLine();
            Console.WriteLine("******************************************************");
            Console.WriteLine();
            Console.WriteLine("Create an input.txt file at current file directory");
            Console.WriteLine();
            Console.WriteLine("******************************************************");
            Console.WriteLine();

            Console.WriteLine("Press Enter to Start");
            Console.ReadLine();
        }

        private static void Exit()
        {
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
