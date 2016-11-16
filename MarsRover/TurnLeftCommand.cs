using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    class TurnLeftCommand : ICommands
    {
        public void Execute(Rover rover, Plateau plateau)
        {
            switch (rover.Direction)
            {
                case 'N':
                    rover.Direction = 'W';
                    break;
                case 'E':
                    rover.Direction = 'N';
                    break;
                case 'S':
                    rover.Direction = 'E';
                    break;
                case 'W':
                    rover.Direction = 'S';
                    break;
                default:
                    break;
            }
        }
    }
}
