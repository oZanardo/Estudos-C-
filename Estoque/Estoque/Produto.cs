using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Estoque
{
    internal class Produto
    {
        public string Nome;
        public int Quantidade;
        public double Preco;

        public double ValorTotal()
        {
            return Quantidade * Preco;
        }


        //VOIDS, São funções que em si não tem valor, porém pode intervir em outras variaveis
        public void EntradaEstoque(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void SaidaEstoque(int saida)
        {
            Quantidade = Quantidade - saida;
        }

        //Convertando a classe para String
        public override string ToString()
        {
            return Nome + ", " + Quantidade + " Unidades, R$" + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
