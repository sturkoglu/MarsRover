using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    class RoverOperator
    {
        ICommands cmd = null;
        
        public ICommands GetCommand(char operant)
        {
            switch (operant)
            {
                case 'M':
                    cmd = new MoveCommand();
                    break;
                case 'L':
                    cmd = new TurnLeftCommand();
                    break;
                case 'R':
                    cmd = new TurnRightCommand();
                    break;
                default:
                    break;
            }
            return cmd;
        }
    }
}
