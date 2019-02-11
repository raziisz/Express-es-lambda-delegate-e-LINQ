using Action.Entidades;
using System;
using System.Collections.Generic;

namespace Action
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //list.ForEach(AtualizarPreco); com funcao
            //Action<Product> act = AtualizarPreco; // Delegate recebendo funcao
            //Action<Product> act = p => { p.Preco += p.Preco * 0.1; }; // Delegate recebendo funcao lambda
            //list.ForEach(act);
            list.ForEach(p => { p.Preco += p.Preco * 0.1; }); // for each recebendo expressao lambda

            foreach (var produto in list)
            {
                Console.WriteLine(produto);
            }
        }

        static void AtualizarPreco(Product p)
        {
            p.Preco += p.Preco * 0.1;
        }
    }
}
