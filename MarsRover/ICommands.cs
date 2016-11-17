﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public interface ICommands
    {
        void Execute(CommandParameters commandParameter, Plateau plateau);
    }
}
