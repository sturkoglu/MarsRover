using System.Collections.Generic;
using System.IO;
using MarsRovers.Core;

namespace MarsRovers.Business
{
    public class FileService : IFileService
    {
        public List<string> ReadDocument(string fileName)
        {
            var lines = new List<string>();

            var path = Path.Combine(Directory.GetCurrentDirectory(), fileName);

            if (!IsDocumentExist(path)) return lines;

            using (var sr = File.OpenText(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            return lines;
        }

        public bool IsDocumentExist(string path)
        {
            return File.Exists(path);
        }
    }
}
