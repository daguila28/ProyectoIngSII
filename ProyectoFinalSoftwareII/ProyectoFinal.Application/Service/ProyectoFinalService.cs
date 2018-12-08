using ProyectoFinal.Domain.Common;
using ProyectoFinal.Domain.Entidades;
using ProyectoFinal.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Application.Service
{
    public class ProyectoFinalService : IProyectoFinalService
    {

        private IRepository<Customer> _Customer;
        private IRepository<Order> _Order;
        private IRepository<Product> _Product;

        public ProyectoFinalService( IRepository<Customer> customers, IRepository<Order> orders, IRepository<Product> products,OrderService orderService)
        {
            _Customer = customers;
            _Order = orders;
            _Product = products;

        }

        public void CreateOrder(Order order)
        {

        }
    }
}