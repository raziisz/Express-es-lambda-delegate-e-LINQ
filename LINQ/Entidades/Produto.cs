using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ.Entidades
{
    class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Categoria Categoria { get; set; }

        public Produto(int id, string nome, double preco, Categoria categoria)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Categoria = categoria;
        }
    }
}
