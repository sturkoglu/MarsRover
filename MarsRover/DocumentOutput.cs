using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public class DocumentOutput : IDocumentWrite
    {
        private string outputDocumentName;
        private string path;

        public DocumentOutput(string outputDocumentName) 
        {
            this.outputDocumentName = outputDocumentName;
            this.path = Path.Combine(Directory.GetCurrentDirectory(), outputDocumentName);

            DeleteDocument(this.path);
        }

        public void AddLineToDocument(string line)
        {
            if (IsDocumentExist(this.path))
            {
                using (StreamWriter sw = File.AppendText(this.path))
                {
                    sw.WriteLine(line);
                }
            }
            else 
            {
                using (StreamWriter sw = File.CreateText(this.path))
                {
                    sw.WriteLine(line);
                }
            }
        }

        public bool IsDocumentExist(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }
            else
                return false;
        }

        public void DeleteDocument(string path)
        {
            if (File.Exists(path))
                File.Delete(path);
            
        }
    }
}
