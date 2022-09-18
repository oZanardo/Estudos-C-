using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_de_banco
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Variável

            char depositoIni;
            Conta_Banco conta;
            int nrConta;
            string nomeConta;


            //Tela
            Console.Write("Entre com o número da conta : ");
            nrConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta : ");
            nomeConta = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            depositoIni = char.Parse(Console.ReadLine());
            if (depositoIni == 's' || depositoIni == 'S')
            {
                Console.Write("Entre o valor de depósito inicial : $");
                double saldo = double.Parse(Console.ReadLine());

                conta = new Conta_Banco( nrConta, nomeConta, saldo);
            }
            else
            {
                conta = new Conta_Banco(nrConta, nomeConta, 0);
            }
                
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com um valor para depósito: ");
            double modSaldo = double.Parse(Console.ReadLine());
            conta.AdicionarSaldo(modSaldo);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            modSaldo = double.Parse(Console.ReadLine());
            conta.Saque(modSaldo);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.ReadKey();
        }
    }
}
