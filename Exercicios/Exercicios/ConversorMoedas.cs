using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class ConversorMoedas
    {
        public static double IOF = 6;

        public static double Conversao(double moeda, double comprar)
        {
            return (moeda * comprar) + (moeda * comprar * 0.06) ;
        }
    }
}
