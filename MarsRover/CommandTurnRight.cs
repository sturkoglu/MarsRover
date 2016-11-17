using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public class CommandTurnRight : ICommands
    {
        public void Execute(CommandParameters commandParameter, Plateau plateau)
        {
            switch (commandParameter.DirectionParameter)
            {
                case 'N':
                    commandParameter.DirectionParameter = 'E';
                    break;
                case 'E':
                    commandParameter.DirectionParameter = 'S';
                    break;
                case 'S':
                    commandParameter.DirectionParameter = 'W';
                    break;
                case 'W':
                    commandParameter.DirectionParameter = 'N';
                    break;
                default:
                    break;
            }
        }
    } 
}
