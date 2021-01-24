using System.Collections.Generic;
using MarsRovers.Core.Enums;

namespace MarsRovers.Core
{
    public interface IRover
    {
        short XCoordinate { get; }
        short YCoordinate { get; }
        DirectionType Direction { get; }
        IList<CommandType> Commands { get; }
    }
}