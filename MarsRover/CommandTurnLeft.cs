using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public class CommandTurnLeft : ICommand
    {
        public CommandParameter Execute(CommandParameter inputParameters, Plateau plateau)
        {
            CommandParameter outputParameters = inputParameters;

            switch (inputParameters.DirectionParameter)
            {
                case 'N':
                    outputParameters.DirectionParameter = 'W';
                    break;
                case 'E':
                    outputParameters.DirectionParameter = 'N';
                    break;
                case 'S':
                    outputParameters.DirectionParameter = 'E';
                    break;
                case 'W':
                    outputParameters.DirectionParameter = 'S';
                    break;
                default:
                    break;
            }
            return outputParameters;
        }
    }
}
