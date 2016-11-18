using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public class InputDocument : IDocumentRead
    {
        private string inputDocumentName;
        private string path;

        public InputDocument(string inputDocumentName) 
        {
            this.inputDocumentName = inputDocumentName;
            this.path = Path.Combine(Directory.GetCurrentDirectory(), inputDocumentName);
        }

        public List<string> ReadDocument() 
        {
            string line = "";
            List<string> lines = new List<string>();

            if (IsDocumentExist(this.path)) 
            {
                using (StreamReader sr = File.OpenText(this.path))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
            }

            return lines;
        }

        public bool IsDocumentExist(string path) 
        {
            if (File.Exists(path))
                return true;
            else
                return false;
        }
    }
}
