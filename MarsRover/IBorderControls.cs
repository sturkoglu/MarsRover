﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    interface IBorderControls
    {
        bool MoveCommandBorderControl(CommandParameter commandParameter, Plateau plateau);
    }
}