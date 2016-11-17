using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public interface ICommand
    {
        CommandParameter Execute(CommandParameter commandParameter, Plateau plateau);
    }
}
