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
        private string _nome;
        public int _quantidade;
        public double _preco;

        //Construtores
        public Produto() { }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }

        //Métodos
        public double ValorTotal()
        {
            return _quantidade * _preco;
        }

        //Métodos "Get" e "Set"
        public string GetNome()
        {
            return _nome;
        }// Método Get serve para pegar o valor da variável
         // e mostra-lá no programa sem precisar entrar em
         // contato direto com a variável

        public string GetValor()
        {
            if (_quantidade >= 5)
            {
                return "Valor total do pedido é : R$" + Convert.ToString(ValorTotal());
            }
            else
            {
                return "Quantidade do pedido minimo é 5";
            }
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }// Método Set serve para substituir o valor da variável
         // sem precisar entrar em contato direto com a variável

        //VOIDS, São funções que em si não tem valor, porém pode intervir em outras variaveis
        public void EntradaEstoque(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void SaidaEstoque(int saida)
        {
            _quantidade -= saida;
        }

        //Convertando a classe para String
        public override string ToString()
        {
            return _nome + ", " + _quantidade + " Unidades, R$" + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
