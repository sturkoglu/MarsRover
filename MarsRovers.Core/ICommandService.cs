using System.Collections.Generic;
using MarsRovers.Core.Enums;

namespace MarsRovers.Core
{
    public interface ICommandService
    {
        IPlateau GetPlateau(List<string> commandList);
        List<IRover> GetRovers(List<string> commandList);
        (short xBorder, short yBorder) GetPlateauParameters(string commandLine);
        (short xCoordinate, short yCoordinate, DirectionType direction) GetRoverParameters(string commandLine);
        IList<CommandType> GetRoverCommands(string commandLine);
    }
}