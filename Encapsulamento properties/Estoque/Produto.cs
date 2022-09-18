using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime;

namespace Estoque
{
    internal class Produto
    {
        private string _nome;
        public int Quantidade { get; private set; }
        public double Preco { get; private set; }

        //Construtores
        public Produto() { }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        //Métodos
        public double ValorTotal()
        {
            return Quantidade * Preco;
        }

        //Métodos Properties
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1) { _nome = value; }
            }//value é o valor de entrada e null é um valor nulo
        }

        public string ValorPedido
        {
            get
            {
                if (Quantidade >= 5)
                {
                    return "Valor total do pedido é : R$" + Convert.ToString(ValorTotal());
                }
                else
                {
                    return "Quantidade do pedido minimo é 5";
                }
            }
        }

        //VOIDS, São funções que em si não tem valor, porém pode intervir em outras variaveis
        public void EntradaEstoque(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void SaidaEstoque(int saida)
        {
            Quantidade -= saida;
        }

        //Convertando a classe para String
        public override string ToString()
        {
            return _nome + ", " + Quantidade + " Unidades, R$" + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
