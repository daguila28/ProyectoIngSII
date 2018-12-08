using ProyectoFinal.Application.DTOS;
using ProyectoFinal.Application.Service;
using ProyectoFinal.Domain.Common;
using ProyectoFinal.Domain.Entidades;
using ProyectoFinal.Domain.Services;
using ProyectoFinal.InfraEstructure;
using ProyectoFinal.InfraEstructure.Common;
using ProyectoFinal.InfraEstructure.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Contexts;
using System.Web.Http;

namespace Inventario.Controllers
{
    public class InventarioController : ApiController
    {
        private readonly ProyectoFinalService _proyectoFinal;
        private readonly InventarioDbContext _context1;

        public InventarioController()
        {
            OrderService orderService = new OrderService();
            DbContext dbContext = new InventarioDbContext();
            IRepository<Customer> customerRep = new Repository<Customer>(dbContext);
            IRepository<Order> orderRep = new Repository<Order>(dbContext);
            IRepository<Product> productRep = new Repository<Product>(dbContext);
            _proyectoFinal = new ProyectoFinalService(customerRep, orderRep,productRep,orderService);
        }

        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var cliente = _context1.customers.Find(id);
           if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }


        public IHttpActionResult Delete(int id)
        {
            var cliente = _context1.customers.Find(id);
            if (cliente == null)
            {
                return NotFound();
            }
            _context1.customers.Remove(cliente);
            _context1.SaveChanges();
            return Ok();
        }


    }
}
