using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public class RoverOperator
    {
        ICommand cmd = null;
        
        public ICommand GetCommand(char operant)
        {
            switch (operant)
            {
                case 'M':
                    cmd = new CommandMove();
                    break;
                case 'L':
                    cmd = new CommandTurnLeft();
                    break;
                case 'R':
                    cmd = new CommandTurnRight();
                    break;
                default:
                    break;
            }
            return cmd;
        }
    }
}
