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
        public ICommand roverCommand;

        public Rover(short xCoordinate, short yCoordinate, char direction) 
        {
            this.xCoordinate = xCoordinate;
            this.yCoordinate = yCoordinate;
            this.direction = direction;
        }

        public void ExecuteCommandQueue(Plateau plateau) 
        {
            RoverOperator roverOperator = new RoverOperator();
            CommandParameter inputParameters = null, outputParameters = null;

            try
            {
                for (int i = 0; i < commandQueue.Count(); i++)
                {
                    inputParameters = GetRoverParameters();

                    roverCommand = roverOperator.GetCommand(commandQueue[i]);
                    if (roverCommand == null)
                    {
                        Console.WriteLine("Invalid command '" + commandQueue[i] + "' had been canceled");
                    }
                    else 
                    {
                        outputParameters = roverCommand.Execute(inputParameters, plateau);
                        UpdateRoverParameters(outputParameters);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void UpdateRoverParameters(CommandParameter outputParameters)
        {
            this.XCoordinate = outputParameters.XCoordinateParameter;
            this.YCoordinate = outputParameters.XCoordinateParameter;
            this.Direction = outputParameters.DirectionParameter;
        }

        private CommandParameter GetRoverParameters() 
        {
            CommandParameter commandParameters = new CommandParameter(this.XCoordinate, this.YCoordinate, this.Direction);
            return commandParameters;
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
