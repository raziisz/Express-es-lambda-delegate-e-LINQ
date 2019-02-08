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

            //Comparison<Produto> comp = (p1, p2) => p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper());
            produtos.Sort((p1, p2) => p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper()));

            foreach (var produto in produtos)
            {

                Console.WriteLine(produto);
            }
        }

       
    }
}
