using MarsRovers.Core;
using MarsRovers.Core.Enums;

namespace MarsRovers.Business
{
    public class Command : ICommand
    {
        public short XCoordinate { get; }
        public short YCoordinate { get; }
        public CommandType Direction { get; }

        public Command(short xCoordinate, short yCoordinate, CommandType direction)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            Direction = direction;
        }
    }
}
