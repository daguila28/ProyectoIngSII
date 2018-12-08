using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Domain.Entidades
{
    public class Order
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; }
        public DateTime Date  { get; set; }
        public string Status { get; set; }
        public Customer Customer { get; set; }
        public double Total { get; set; }

        public Order(int id, List<Product> products, Customer customer)
        {
            Id = id;
            Products = products;
            Customer = customer;
            Status = "pendiente";
            Date = Date.Date;
            Total = 0;

        }
    }
}
