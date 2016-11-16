using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public class TurnRightCommand : ICommands
    {
        public void Execute(Rover rover, Plateau plateau)
        {
            switch (rover.Direction)
            {
                case 'N':
                    rover.Direction = 'E';
                    break;
                case 'E':
                    rover.Direction = 'S';
                    break;
                case 'S':
                    rover.Direction = 'W';
                    break;
                case 'W':
                    rover.Direction = 'N';
                    break;
                default:
                    break;
            }
        }
    } 
}
