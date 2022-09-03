using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 1;

            //calculos retangulo
            do
            {
                /*
                //Variaveis
                Retangulo retangulo = new Retangulo();

                //TELA
                Console.WriteLine("Entre a largura e altura do retangulo : ");
                retangulo.Altura = double.Parse(Console.ReadLine());
                retangulo.Largura = double.Parse(Console.ReadLine());

                Console.WriteLine("Area = " + retangulo.Area());
                Console.WriteLine("Perimetro = " + retangulo.Perimetro());
                Console.WriteLine("Linha diagonal = " + retangulo.Diagonal());
                Console.ReadLine();*/
            } while (a == 0);

            //Dados de funcionário
            do
            {
                /*
                //Variaveis
                Funcionario dados = new Funcionario();
                double aumento;


                //Tela
                Console.Write("Nome : ");
                dados.Nome = Console.ReadLine();

                Console.Write("Salário Bruto : ");
                dados.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Console.Write("Imposto : ");
                dados.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Funcionário : " + dados);
                Console.WriteLine();
                
                Console.Write("Digite a porcentagem para aumentar o salário : ");
                aumento = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                dados.Aumento(aumento);

                Console.WriteLine("Dados atualizados : " + dados);
                */
            } while (a == 0);

            //Médias
            do
            {
                /*
                //Variaveis

                Aluno aluno = new Aluno();

                //Tela

                Console.Write("Nome do aluno : ");
                aluno.Nome = Console.ReadLine();
                Console.WriteLine("Digite as três notas do aluno :");
                aluno.PNota = double.Parse(Console.ReadLine());
                aluno.SNota = double.Parse(Console.ReadLine());
                aluno.TNota = double.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Nota final = " + aluno.NotaFinal());

                if (aluno.NotaFinal() > 60)
                {
                    Console.WriteLine("APROVADO");
                }
                else
                {
                    double diferenca = 60 - aluno.NotaFinal();
                    Console.WriteLine("REPROVADO");
                    Console.WriteLine("FALTARAM " + diferenca.ToString('F2') + " PONTOS");
                }
                */
            } while (a == 0);

            do {

                Console.WriteLine("Qual é a cotação do dólar ?");
                double dolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.WriteLine("Quantos dólares você vai comprar ?");
                double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double valorPago = ConversorMoedas.Conversao(dolar, quantia);
                Console.WriteLine("Valor a ser pago em reais = " + valorPago.ToString("F2", CultureInfo.InvariantCulture));
            
            
            }while (a == 0);
            
            Console.ReadLine();


        }
    }
}
