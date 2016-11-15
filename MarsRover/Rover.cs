using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    class Rover
    {
        public short xCoordinate { get; set; }
        public short yCoordinate { get; set; }
        public char direction { get; set; }
        public char[] commandQueue;

        public Rover(short xCoordinate, short yCoordinate, char direction) 
        {
            this.xCoordinate = xCoordinate;
            this.yCoordinate = yCoordinate;
            this.direction = direction;
        }

    }
}
