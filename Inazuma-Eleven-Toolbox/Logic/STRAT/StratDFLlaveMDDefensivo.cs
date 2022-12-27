﻿using Inazuma_Eleven_Toolbox.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inazuma_Eleven_Toolbox.Logic.STRAT
{
    public class StratDFLlaveMDDefensivo : IStratBase
    {
        public StratDFLlaveMDDefensivo()
        {

        }
        public HeavenReturn Execute(Heaven heaven)
        {
            var aguntPro = 1;
            var controlPro = heaven.Control + 50;
            var defensaPro = 1;
            var fisicoPro = heaven.Fisico + 50;
            var rapidezPro = heaven.Rapidez + 50;
            var tiroPro = 1;
            var valorPro = heaven.Valor + 50;

            var tot = aguntPro + controlPro + defensaPro + fisicoPro + rapidezPro + tiroPro + valorPro;

            var restante = (heaven.SumStat) + 20 - tot;

            HeavenReturn calculate = new HeavenReturn();

            if (restante > 0)
            {
                calculate.Aguante = ((heaven.Aguante * -1) + 1) + restante;
                calculate.Rapidez = 50;
            }
            else
            {
                calculate.Rapidez = 50 + restante;
                calculate.Aguante = ((heaven.Aguante * -1) + 1);
            }



            calculate.Valor = 50;
            calculate.Control = 50;
            calculate.Defensa = (heaven.Defensa * -1) + 1;
            calculate.Fisico = 50;
            calculate.Tiro = (heaven.Tiro * -1) + 1;
            return calculate;
        }

    }
}
