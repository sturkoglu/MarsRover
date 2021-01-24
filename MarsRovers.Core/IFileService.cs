using System.Collections.Generic;

namespace MarsRovers.Core
{
    public interface IFileService
    {
        List<string> ReadDocument(string fileName);
    }
}