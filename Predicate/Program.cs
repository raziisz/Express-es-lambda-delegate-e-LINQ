﻿using Predicate.Classes;
using System;
using System.Collections.Generic;

namespace Predicate
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

            //list.RemoveAll(p => p.Preco >= 100.0); Com expressao
            list.RemoveAll(ProdutoTeste);

            foreach (var produto in list)
            {
                Console.WriteLine(produto);
            }
        }

        public static bool ProdutoTeste(Product p)
        {
            return p.Preco >= 100.0;
        }
    }
}
