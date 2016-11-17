using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public class CommandTurnLeft : ICommands
    {
        public void Execute(CommandParameters commandParameter, Plateau plateau)
        {
            switch (commandParameter.DirectionParameter)
            {
                case 'N':
                    commandParameter.DirectionParameter = 'W';
                    break;
                case 'E':
                    commandParameter.DirectionParameter = 'N';
                    break;
                case 'S':
                    commandParameter.DirectionParameter = 'E';
                    break;
                case 'W':
                    commandParameter.DirectionParameter = 'S';
                    break;
                default:
                    break;
            }
        }
    }
}
