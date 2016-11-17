using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public class RoverOperator
    {
        ICommands cmd = null;
        
        public ICommands GetCommand(char operant, out bool isValidCommand)
        {
            switch (operant)
            {
                case 'M':
                    cmd = new CommandMove();
                    isValidCommand = true;
                    break;
                case 'L':
                    cmd = new CommandTurnLeft();
                    isValidCommand = true;
                    break;
                case 'R':
                    cmd = new CommandTurnRight();
                    isValidCommand = true;
                    break;
                default:
                    isValidCommand = false;
                    break;
            }
            return cmd;
        }
    }
}
