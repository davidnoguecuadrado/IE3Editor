using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inazuma_Eleven_Toolbox.Logic.SPEC
{
    class SpecMetodoLeo : ISpecBase
    {
        public SpecMetodoLeo()
        {

        }

        public bool IsValid(string type)
        {
            return type == "Método Leo";
        }
    }
}
