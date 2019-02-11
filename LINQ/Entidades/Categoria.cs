using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ.Entidades
{
    class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Tier { get; set; }

        public Categoria()
        {

        }

        public Categoria(int id, string nome, int tier)
        {
            Id = id;
            Nome = nome;
            Tier = tier;
        }
    }
}
