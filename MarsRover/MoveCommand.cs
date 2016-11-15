using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    class MoveCommand : ICommands
    {
        public void Execute(Rover rover)
        {
            switch (rover.direction) 
            {
                case 'N':
                    rover.yCoordinate++;
                    break;
                case 'E':
                    rover.xCoordinate++;
                    break;
                case 'S':
                    rover.yCoordinate--;
                    break;
                case 'W':
                    rover.xCoordinate--;
                    break;
                default:
                    break;
            }
        }

        public bool BorderControl() 
        {
            return true;
        }

    }
}
