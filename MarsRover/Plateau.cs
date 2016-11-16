using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    class Plateau
    {
        private short xBorder;
        private short yBorder;

        public Plateau(short xBorder, short yBorder) 
        {
            this.xBorder = xBorder;
            this.yBorder = yBorder;
        }

        public short XBorder
        {
            get
            {
                return xBorder;
            }
            set
            {
                xBorder = value;
            }
        }

        public short YBorder
        {
            get
            {
                return yBorder;
            }
            set
            {
                yBorder = value;
            }
        }
    }
}
