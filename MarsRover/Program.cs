using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    class Program
    {
        static void Main(string[] args)
        {
            //string plateauArea = Console.ReadLine();
            //string firstRoverInitialPosition = Console.ReadLine();
            //string firstRoverCommandQueue = Console.ReadLine();
            //string secondRoverInitialPosition = Console.ReadLine();
            //string secondRoverCommandQueue = Console.ReadLine();

            string plateauArea = "5 5";
            string firstRoverInitialPosition = "1 2 N";
            string firstRoverCommandQueue = "LMLMLMLRMM";

            Rover rover = new Rover(1, 2, 'N');
            rover.commandQueue = firstRoverCommandQueue.ToCharArray();
            
            RoverOperator roverOperator = new RoverOperator();
            ICommands command = null;

            for (int i = 0; i < rover.commandQueue.Count(); i++)
            {
                command = roverOperator.GetCommand(rover.commandQueue[i]);
                command.Execute(rover);
            }
            
        }
    }
}
