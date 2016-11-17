using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public class InputDocument
    {
        public string inputDocumentName;
        public string outputDocumentName;

        private List<string> inputs = null;

        public InputDocument(string inputDocumentName, string outputDocumentName) 
        {
            this.inputDocumentName = inputDocumentName;
            this.outputDocumentName = outputDocumentName;
        }

        private void ReadDocument(string inputDocumentName) 
        {
            string line = "";
            List<string> lines = null;

            string path = Path.Combine(Directory.GetCurrentDirectory(), inputDocumentName);

            if (IsDocumentExist(path)) 
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
                inputs = lines;
            }

        }

        private bool IsDocumentExist(string path) 
        {
            if (!File.Exists(path))
                return true;
            else
                return false;
        }

        internal List<Rover> GetRoversInformationFromDocument()
        {
            ReadDocument(this.inputDocumentName);

            return null;
        }
    }
}
