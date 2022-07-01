using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inazuma_Eleven_Toolbox.Logic.SPEC
{
    public class SpecDFLlaveMDOfensivo : ISpecBase
    {
        public SpecDFLlaveMDOfensivo()
        {

        }

        public bool IsValid(string type)
        {
            return type == "DF Llave MD Ofensivo";
        }
    }
}
