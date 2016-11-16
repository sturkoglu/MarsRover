using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    class Rover
    {
        public short xCoordinate;
        public short yCoordinate;
        public char direction;
        public char[] commandQueue;

        public RoverOperator roverOperator;
        public ICommands roverCommand;

        public Rover(short xCoordinate, short yCoordinate, char direction) 
        {
            this.xCoordinate = xCoordinate;
            this.yCoordinate = yCoordinate;
            this.direction = direction;
        }

        public void ExecuteCommandQueue() 
        {
            RoverOperator roverOperator = new RoverOperator();

            for (int i = 0; i < commandQueue.Count(); i++)
            {
                roverCommand = roverOperator.GetCommand(commandQueue[i]);
                roverCommand.Execute(this);
            }
        }

    }
}
