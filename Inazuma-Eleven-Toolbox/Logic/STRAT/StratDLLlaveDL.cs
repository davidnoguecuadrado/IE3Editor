using Inazuma_Eleven_Toolbox.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inazuma_Eleven_Toolbox.Logic.STRAT
{
    public class StratDLLlaveDL : IStratBase
    {
        public StratDLLlaveDL()
        {

        }
        public HeavenReturn Execute(Heaven heaven)
        {
            var aguntPro = heaven.Aguante + 50;
            var controlPro = 1;
            var defensaPro = 1;
            var fisicoPro = 1;
            var rapidezPro = heaven.Rapidez + 50;
            var tiroPro = heaven.Tiro + 50;
            var valorPro = heaven.Valor + 50;

            var tot = aguntPro + controlPro + defensaPro + fisicoPro + rapidezPro + tiroPro + valorPro;

            var restante = (heaven.SumStat) + 20 - tot;

            HeavenReturn calculate = new HeavenReturn();

            if (restante > 0)
            {
                calculate.Fisico = ((heaven.Fisico * -1) + 1) + restante;
                calculate.Aguante = 50;
            }
            else
            {
                calculate.Aguante = 50 + restante;
                calculate.Fisico = ((heaven.Fisico * -1) + 1);
            }

            calculate.Valor = 50;
            calculate.Control = (heaven.Control * -1) + 1;
            calculate.Defensa = (heaven.Defensa * -1) + 1;
            calculate.Tiro = 50;
            calculate.Rapidez = 50 ;


            return calculate;
        }
    }
}
