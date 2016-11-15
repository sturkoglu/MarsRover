using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    class TurnRightCommand : ICommands
    {
        public void Execute(Rover rover)
        {
            switch (rover.direction)
            {
                case 'N':
                    rover.direction = 'E';
                    break;
                case 'E':
                    rover.direction = 'S';
                    break;
                case 'S':
                    rover.direction = 'W';
                    break;
                case 'W':
                    rover.direction = 'N';
                    break;
                default:
                    break;
            }
        }
    } 
}
