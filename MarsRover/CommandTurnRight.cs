using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public class CommandTurnRight : ICommand
    {
        public CommandParameter Execute(CommandParameter inputParameters, Plateau plateau)
        {
            switch (inputParameters.DirectionParameter)
            {
                case 'N':
                    inputParameters.DirectionParameter = 'E';
                    break;
                case 'E':
                    inputParameters.DirectionParameter = 'S';
                    break;
                case 'S':
                    inputParameters.DirectionParameter = 'W';
                    break;
                case 'W':
                    inputParameters.DirectionParameter = 'N';
                    break;
                default:
                    break;
            }
            return inputParameters;
        }
    } 
}
