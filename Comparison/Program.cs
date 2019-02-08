using System;
using System.Collections.Generic;

namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Produto("Feijao", 3.00));
            produtos.Add(new Produto("Arroz", 4.00));
            produtos.Add(new Produto("Farinha", 5.00));
            produtos.Add(new Produto("Macarrão", 3.50));

            produtos.Sort(ComparaProduto);

            foreach (var produto in produtos)
            {

                Console.WriteLine(produto);
            }
        }

        static int ComparaProduto(Produto p1, Produto p2)
        {
            return p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper());
        }
    }
}
