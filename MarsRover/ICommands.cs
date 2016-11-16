using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public interface ICommands
    {
        void Execute(Rover rover, Plateau plateau);
        //Left ve Right donuslarinde kotrol yapilmasi analiz edilir ise Interface sinifina BorderCotrol methodu eklebilir
        //bool BorderControl();
    }
}
