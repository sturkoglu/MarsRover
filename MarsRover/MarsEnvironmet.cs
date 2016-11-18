using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public class MarsEnvironmet
    {
        private string inputDocumentName;
        private List<string> inputs = null;

        public MarsEnvironmet(string inputDocumentName)
        {
            this.inputDocumentName = inputDocumentName;
        }

        internal Plateau GetPlateau()
        {
            string[] parameters;
            this.inputs = GetInputs();

            if (inputs != null)
            {
                parameters = inputs[0].Split(' ');
                return new Plateau(Convert.ToInt16(parameters[0]), Convert.ToInt16(parameters[1]));
            }
            else
                return null;
        }

        internal List<Rover> GetRovers()
        {
            string[] parameters;
            Rover rover;
            List<Rover> Rovers = new List<Rover>();

            this.inputs = GetInputs();
            if (inputs != null)
            {
                for (int i = 1; i < inputs.Count(); i += 2)
                {
                    parameters = inputs[i].Split(' ');
                    rover = new Rover(Convert.ToInt16(parameters[0]), Convert.ToInt16(parameters[1]), Convert.ToChar(parameters[2]));
                    rover.commandQueue = inputs[i + 1].ToCharArray();
                    Rovers.Add(rover);
                }
                return Rovers;
            }
            else
                return null;
        }

        private List<string> GetInputs() 
        {
            DocumentInput inputDocument = new DocumentInput(this.inputDocumentName);
            return inputDocument.ReadDocument();
        }
    }
}
