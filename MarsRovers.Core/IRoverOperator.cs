using MarsRovers.Core.Enums;

namespace MarsRovers.Core
{
    public interface IRoverOperator : IOperator<IRover> , IEnvironment<IPlateau>
    {
        (short xCoordinate, short yCoordinate, DirectionType direction) GetRoverPosition();
        void Execute();
    }
}