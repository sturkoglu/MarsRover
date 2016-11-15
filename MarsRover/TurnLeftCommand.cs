using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    class TurnLeftCommand : ICommands
    {
        public void Execute(Rover rover)
        {
            switch (rover.direction)
            {
                case 'N':
                    rover.direction = 'W';
                    break;
                case 'E':
                    rover.direction = 'N';
                    break;
                case 'S':
                    rover.direction = 'E';
                    break;
                case 'W':
                    rover.direction = 'S';
                    break;
                default:
                    break;
            }
        }
    }
}
