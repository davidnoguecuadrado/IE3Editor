﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inazuma_Eleven_Toolbox.Logic.SPEC
{
    public class SpecDLLlaveMDFísico : ISpecBase 
    {
        public SpecDLLlaveMDFísico()
        {

        }

        public bool IsValid(string type)
        {
            return type == "DL Llave MD";
        }
    }
}
