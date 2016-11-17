using System;
using System.Collections.Generic;
using System.IO;
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
            string inputFileName = "input.txt";
            string outputFileName = "output.txt";
            
            List<Rover> rovers = null;

            InputDocument documentOperations = new InputDocument(inputFileName, outputFileName);


            rovers = documentOperations.GetRoversInformationFromDocument();


            string firstRoverCommandQueue = "LMMMMLMLMLRM";
            
            Plateau plateau = new Plateau(5, 5);
            Rover rover = new Rover(1, 2, 'N');
            rover.commandQueue = firstRoverCommandQueue.ToCharArray();

            rover.ExecuteCommandQueue(plateau);
            Console.ReadLine();
        }
    }
}
