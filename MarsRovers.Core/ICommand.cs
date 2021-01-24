using MarsRovers.Core.Enums;

namespace MarsRovers.Core
{
    public interface ICommand
    {
        short XCoordinate { get; }
        short YCoordinate { get; }
        CommandType Direction { get; }
    }
}