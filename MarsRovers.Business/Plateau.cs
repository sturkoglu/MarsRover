using MarsRovers.Core;

namespace MarsRovers.Business
{
    public class Plateau : IPlateau
    {
        public short XBorder { get; }
        public short YBorder { get; }
        
        public Plateau(short xBorder, short yBorder)
        {
            XBorder = xBorder;
            YBorder = yBorder;
        }
    }
}
