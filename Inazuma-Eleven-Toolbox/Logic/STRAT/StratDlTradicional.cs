using Inazuma_Eleven_Toolbox.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inazuma_Eleven_Toolbox.Logic.STRAT
{
    public class StratDlTradicional : IStratBase
    {
        public StratDlTradicional() { 
        
        }
        public HeavenReturn Execute(Heaven heaven) {

            var aguntPro = 1;
            var controlPro = 1;
            var defensaPro = heaven.Defensa + 50;
            var fisicoPro = heaven.Fisico + 50;
            var rapidezPro = heaven.Rapidez + 50;
            var tiroPro = heaven.Tiro + 50;
            var valorPro = 1;

            var tot = aguntPro + controlPro + defensaPro + fisicoPro + rapidezPro + tiroPro + valorPro;

            var restante = (heaven.SumStat) + 20 - tot;

            HeavenReturn calculate = new HeavenReturn();

            if (restante > 0) {
                calculate.Valor = ((heaven.Valor * -1) + 1) + restante;
                calculate.Rapidez = 50;
            }
            else {
                calculate.Rapidez = 50 + restante;
                calculate.Valor = ((heaven.Valor * -1) + 1);
            }



            calculate.Aguante = (heaven.Aguante * -1) + 1;
            calculate.Control = (heaven.Control * -1) + 1;
            calculate.Defensa = 50;
            calculate.Fisico = 50;
            calculate.Tiro = 50;
            return calculate;
        }
    }
}
