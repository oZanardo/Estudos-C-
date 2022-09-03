using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classe
            Produto produtoEstoque = new Produto();

            //Variaveis
            int entrada;
            int saida;

            //TELA
            Console.WriteLine("Entre com os dados do produto :");

            Console.Write("Nome : ");
            produtoEstoque.Nome = Console.ReadLine();


            Console.Write("Preço : ");
            produtoEstoque.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Quantidade no estoque : ");
            produtoEstoque.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Dados do produto : " + produtoEstoque);
            
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado no estoque : ");
            entrada = int.Parse(Console.ReadLine());
            produtoEstoque.EntradaEstoque(entrada);

            Console.WriteLine("Dados do produto : " + produtoEstoque);

            Console.Write("Digite o número de produtos á serem retirados do estoque : ");
            saida = int.Parse(Console.ReadLine());
            produtoEstoque.SaidaEstoque(saida);

            Console.WriteLine("Dados do produto : " + produtoEstoque);
        
        }
    }
}