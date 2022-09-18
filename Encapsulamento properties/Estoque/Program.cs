using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do produto em estoque : TV(modelo 4k, FullHd 144hz), 800.00, 100 un");

            Console.Write("Quantas unidades deseja comprar : ");

            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto("Tv", 800.00, quantidade);

            Console.Write("Escreva o nome do Modelo escolhido : ");
            p.Nome = Console.ReadLine();

            Console.WriteLine(p.Nome + "," + p.ValorPedido);
        }
    }
}