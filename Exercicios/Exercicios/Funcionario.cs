using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiq()
        {
            return SalarioBruto - Imposto;
        }

        
        public void Aumento(double Porcentagem)
        {
            SalarioBruto += (SalarioBruto * Porcentagem) / 100;
        }

        public override string ToString()
        {
            return Nome + ", R$ " + SalarioLiq() + ".";
        }

    }
}
