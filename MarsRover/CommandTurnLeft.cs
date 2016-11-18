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
            switch (inputParameters.DirectionParameter)
            {
                case 'N':
                    inputParameters.DirectionParameter = 'W';
                    break;
                case 'E':
                    inputParameters.DirectionParameter = 'N';
                    break;
                case 'S':
                    inputParameters.DirectionParameter = 'E';
                    break;
                case 'W':
                    inputParameters.DirectionParameter = 'S';
                    break;
                default:
                    break;
            }
            return inputParameters;
        }
    }
}
