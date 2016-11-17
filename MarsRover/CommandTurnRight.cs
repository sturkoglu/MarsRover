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
            CommandParameter outputParameters = inputParameters;

            switch (inputParameters.DirectionParameter)
            {
                case 'N':
                    outputParameters.DirectionParameter = 'E';
                    break;
                case 'E':
                    outputParameters.DirectionParameter = 'S';
                    break;
                case 'S':
                    outputParameters.DirectionParameter = 'W';
                    break;
                case 'W':
                    outputParameters.DirectionParameter = 'N';
                    break;
                default:
                    break;
            }
            return outputParameters;
        }
    } 
}
