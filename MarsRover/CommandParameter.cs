using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public class CommandParameter
    {
        private short xCoordinateParameter;
        private short yCoordinateParameter;
        private char directionParameter;

        public CommandParameter(short xCoordinateParameter, short yCoordinateParameter, char directionParameter) 
        {
            this.xCoordinateParameter = xCoordinateParameter;
            this.yCoordinateParameter = yCoordinateParameter;
            this.directionParameter = directionParameter;
        }

        public short XCoordinateParameter
        {
            get
            {
                return xCoordinateParameter;
            }
            set
            {
                xCoordinateParameter = value;
            }
        }

        public short YCoordinateParameter
        {
            get
            {
                return yCoordinateParameter;
            }
            set
            {
                yCoordinateParameter = value;
            }
        }

        public char DirectionParameter
        {
            get
            {
                return directionParameter;
            }
            set
            {
                directionParameter = value;
            }
        }

    }
}
