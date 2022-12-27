using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inazuma_Eleven_Toolbox.Logic.SPEC
{
    public class SpecDFLlaveMDDefensivo : ISpecBase
    {
        public SpecDFLlaveMDDefensivo()
        {

        }

        public bool IsValid(string type)
        {
            return type == "DF Llave MD Defensivo";
        }
    }
}
