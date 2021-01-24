namespace MarsRovers.Core
{
    public interface IOperator<T>
    {
        void ConnectTo(T operatee);
    }
}