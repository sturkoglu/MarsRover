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
            Plateau plateau;
            List<Rover> rovers = null;

            MarsEnvironmet marsEnvironment;
            OutputDocument outputDocument;

            string inputFileName = "input.txt";
            string outputFileName = "output.txt";


            marsEnvironment = new MarsEnvironmet(inputFileName);
            outputDocument = new OutputDocument(outputFileName);
            
            plateau = marsEnvironment.GetPlateau();
            
            rovers = marsEnvironment.GetRovers();

            if (plateau != null && rovers != null)
            {
                foreach (Rover rover in rovers)
                {
                    rover.ExecuteCommandQueue(plateau);
                    outputDocument.AddLineToDocument(rover.XCoordinate.ToString() + " " + rover.YCoordinate.ToString() + " " + rover.Direction.ToString());
                }
            }else
                Console.WriteLine("Incorrect Input, please check the input file again");

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
