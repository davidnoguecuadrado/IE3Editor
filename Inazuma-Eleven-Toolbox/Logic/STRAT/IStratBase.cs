﻿using Inazuma_Eleven_Toolbox.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inazuma_Eleven_Toolbox.Logic.STRAT
{
    public interface IStratBase
    {
        HeavenReturn Execute(Heaven heaven);
    }
}
