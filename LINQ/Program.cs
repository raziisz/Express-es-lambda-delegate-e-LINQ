﻿using System.Linq;
using System;
using LINQ.Entidades;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Print<T>(string mensagem, IEnumerable<T> colecao)
        {
            Console.WriteLine(mensagem);
            foreach (T obj in colecao)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Categoria c1 = new Categoria() { Id = 1, Nome = "Tools", Tier = 2 };
            Categoria c2 = new Categoria() { Id = 2, Nome = "Computers", Tier = 1 };
            Categoria c3 = new Categoria() { Id = 3, Nome = "Eletronics", Tier = 1 };

            List<Produto> produtos = new List<Produto>()
            {
                new Produto(){ Id = 1, Nome = "Computer", Preco = 1100.0, Categoria = c2},
                new Produto(){ Id = 2, Nome = "Hammer", Preco = 90.0, Categoria = c1},
                new Produto(){ Id = 3, Nome = "TV", Preco = 1700.0, Categoria = c3},
                new Produto(){ Id = 4, Nome = "Notebook", Preco = 1300.0, Categoria = c2},
                new Produto(){ Id = 5, Nome = "Saw", Preco = 80.0, Categoria = c1},
                new Produto(){ Id = 6, Nome = "Tablet", Preco = 700.0, Categoria = c2},
                new Produto(){ Id = 7, Nome = "Camera", Preco = 700.0, Categoria = c3},
                new Produto(){ Id = 8, Nome = "Printer", Preco = 350.0, Categoria = c3},
                new Produto(){ Id = 9, Nome = "MacBook", Preco = 1800.0, Categoria = c2},
                new Produto(){ Id = 10, Nome = "Sound Bar", Preco = 700.0, Categoria = c3},
                new Produto(){ Id = 11, Nome = "Level", Preco = 70.0, Categoria = c1}
            };

            var r1 = produtos.Where(p => p.Categoria.Tier == 1 && p.Preco < 900.0);
           Print("TIER 1 AND PRICE < 900: ",r1);

            var r2 = produtos.Where(p => p.Categoria.Nome == "Tools").Select(p => p.Nome);
            Print("NOMES DOS PRODUTOS DA CATEGORIA TOOLS", r2);

            var r3 = produtos.Where(p => p.Nome[0] == 'C').Select(p => new { p.Nome, p.Preco, CategoriaNome = p.Categoria.Nome });
            Print("Nome começados com C e objetos anonimos", r3);

        }
    }
}
