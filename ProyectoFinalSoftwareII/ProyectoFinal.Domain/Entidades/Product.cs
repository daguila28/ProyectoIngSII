using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Domain.Entidades
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }

        public Product(int id, string name, string type, double price)
        {
            Id = id;
            Name = name;
            Type = type;
            Price = price;
        }
    }
}
