namespace MarsRovers.Core
{
    public interface IEnvironment<T>
    {
        void SendEnvironment(T environment);
    }
}