using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public class Rover
    {
        private short xCoordinate;
        private short yCoordinate;
        private char direction;
        public char[] commandQueue;

        public RoverOperator roverOperator;
        public ICommands roverCommand;

        public Rover(short xCoordinate, short yCoordinate, char direction) 
        {
            this.xCoordinate = xCoordinate;
            this.yCoordinate = yCoordinate;
            this.direction = direction;
        }


        public void ExecuteCommandQueue(Plateau plateau) 
        {
            RoverOperator roverOperator = new RoverOperator();

            for (int i = 0; i < commandQueue.Count(); i++)
            {
                roverCommand = roverOperator.GetCommand(commandQueue[i]);
                roverCommand.Execute(this, plateau);
            }
        }

        public short XCoordinate
        {
            get
            {
                return xCoordinate;
            }
            set
            {
                xCoordinate = value;
            }
        }

        public short YCoordinate
        {
            get
            {
                return yCoordinate;
            }
            set
            {
                yCoordinate = value;
            }
        }

        public char Direction
        {
            get
            {
                return direction;
            }
            set
            {
                direction = value;
            }
        }

    }
}
