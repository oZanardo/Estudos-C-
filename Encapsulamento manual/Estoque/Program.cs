using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de produtos : ");
            int quantidade = int.Parse(Console.ReadLine());
            
            Produto p = new Produto("PC", 400,quantidade);

            Console.Write("Escreva o nome do Produto : ");
            string nome = Console.ReadLine();
            p.SetNome(nome);

            Console.WriteLine(p.GetNome() + "," + p.GetValor());
        }
    }
}