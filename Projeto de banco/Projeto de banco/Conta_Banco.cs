using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_de_banco
{
    internal class Conta_Banco
    {
        public int NrConta { get; private set; }
        public string NomeTitular { get; private set; }
        public double Saldo { get; private set; }

        public Conta_Banco(int nrConta, string nomeTitular, double saldo)
        {
            NrConta = nrConta;
            NomeTitular = nomeTitular;
            Saldo = saldo;
        }

        public void AdicionarSaldo(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo = Saldo - saque - 5;
        }

        public override string ToString()
        {
            return "Conta " + NrConta + ", Titular: " + NomeTitular + ", Saldo: R$ " + Saldo;
        }
    }
}
