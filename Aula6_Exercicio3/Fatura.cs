using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6_Exercicio3
{
    internal class Fatura
    {
        int numero;
        string descProdutos;
        int qtde;
        double preco;
        double total;

        public void ConstFatura(int numero, string descProdutos, int qtde, double preco)
        {
            this.numero = numero;
            this.descProdutos = descProdutos;
            this.qtde = qtde;
            this.preco = preco;
        }
        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }
        public string DescProdutos
        {
            get
            {
                return descProdutos;
            }
            set
            {
                descProdutos = value;
            }
        }
        public int Qtde
        {
            get
            {
                return qtde;
            }
            set
            {
                qtde = value;
            }
        }
        public double Preco
        {
            get
            {
                return preco;
            }
            set
            {
                preco = value;
            }
        }

        public void Calcular(double preco, double qtde)
        {
            this.total = preco * qtde;
            
            Console.WriteLine(total);
        }
    }
}
