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
            try
            {
                RoverOperator roverOperator = new RoverOperator();
                bool isValidCommand = false;

                for (int i = 0; i < commandQueue.Count(); i++)
                {
                    CommandParameters commandParameters = new CommandParameters(this.xCoordinate, this.yCoordinate, this.direction);

                    roverCommand = roverOperator.GetCommand(commandQueue[i], out isValidCommand);
                    if (isValidCommand)
                    {
                        roverCommand.Execute(commandParameters, plateau);
                    }
                    else 
                    {
                        Console.WriteLine("Invalid command '" + commandQueue[i] + "' had been canceled");
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
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
