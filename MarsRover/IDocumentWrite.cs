using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    interface IDocumentWrite
    {
        bool IsDocumentExist(string path);
        void AddLineToDocument(string line);
        void DeleteDocument(string path);
    }
}
