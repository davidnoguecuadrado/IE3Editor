using Inazuma_Eleven_Toolbox.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inazuma_Eleven_Toolbox.Logic.STRAT
{
    public class StratPorterosLeo : IStratBase
    {
        public StratPorterosLeo()
        {

        }
        public HeavenReturn Execute(Heaven heaven)
        {
            var aguntPro = 1;
            decimal contr = heaven.Control / 2;
            var controlPro = Decimal.ToInt32(Math.Ceiling(contr));
            var defensaPro = heaven.Defensa + 50;
            var fisicoPro = heaven.Fisico + 50;
            var rapidezPro = 1;
            var tiroPro = 1;
            var valorPro = heaven.Rapidez + 50;

            var tot = aguntPro + controlPro + defensaPro + fisicoPro + rapidezPro + tiroPro + valorPro;

            var restante = (heaven.SumStat) + 20 - tot;

            HeavenReturn calculate = new HeavenReturn();

            if (restante > 0)
            {
                calculate.Rapidez = ((heaven.Rapidez * -1) + 1) + restante;
                calculate.Valor = 50;
            }
            else
            {
                calculate.Valor = 50 + restante;
                calculate.Rapidez = ((heaven.Rapidez * -1) + 1);
            }



            calculate.Aguante = (heaven.Aguante * -1) + 1;
            calculate.Control = controlPro * -1;
            calculate.Defensa = 50;
            calculate.Fisico = 50;
            calculate.Tiro = (heaven.Tiro * -1) + 1;
            return calculate;
        }
    }
}
