using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComecandoXaramin.PCL
{
    public class IndiceMassaCorporal
    {
        public static decimal Calcular(decimal peso, decimal altura)
        {
            return peso * (altura * altura);
        }
    }
}
