using System;
using System.Collections.Generic;
using System.Linq;
using MarsRovers.Core;
using MarsRovers.Core.Enums;

namespace MarsRovers.Business
{
    public class CommandService : ICommandService
    {
        public IPlateau GetPlateau(List<string> commandList)
        {
            if (!commandList.Any()) return null;

            var parameters = commandList[0].Split(' ');

            if (parameters.Length != 2) return null;

            short.TryParse(parameters[0], out var xBorder);
            short.TryParse(parameters[1], out var yBorder);

            if (xBorder == 0 || yBorder == 0) return null;

            return new Plateau(xBorder, yBorder);
        }

        public List<IRover> GetRovers(List<string> commandList)
        {
            var roverList = new List<IRover>();

            if (!commandList.Skip(1).Any()) return roverList;

            for (var i = 1; i < commandList.Count; i += 2)
            {
                //Validation needed

                var rover = new Rover();

                var (xCoordinate, yCoordinate, direction) = GetRoverParameters(commandList[i]);
                rover.DeployRover(xCoordinate, yCoordinate, direction);

                var roverCommands = GetRoverCommands(commandList[i + 1]);
                rover.Send(roverCommands);

                roverList.Add(rover);
            }
            return roverList;
        }

        public (short xBorder, short yBorder) GetPlateauParameters(string commandLine)
        {
            var parameters = commandLine.Split(' ');

            short.TryParse(parameters[0], out var xBorder);
            short.TryParse(parameters[1], out var yBorder);

            return (xBorder, yBorder);
        }

        public IList<CommandType> GetRoverCommands(string commandLine)
        {
            //Validation needed
            var roverCommands = commandLine.ToCharArray().Select(x => (CommandType)x).ToList();
            return roverCommands;
        }

        public (short xCoordinate, short yCoordinate, DirectionType direction) GetRoverParameters(string commandLine)
        {
            var parameters = commandLine.Split(' ');

            var xCoordinate = Convert.ToInt16(parameters[0]);
            var yCoordinate = Convert.ToInt16(parameters[1]);
            var direction = (DirectionType)Convert.ToChar(parameters[2]);
            return (xCoordinate, yCoordinate, direction);
        }
    }
}
