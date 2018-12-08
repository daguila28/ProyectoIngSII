using ProyectoFinal.Domain.Entidades;
using ProyectoFinal.InfraEstructure.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.InfraEstructure
{ 
    public class InventarioDbContext : DbContext
    {
       
        public InventarioDbContext(): base("Inventario")
        {
    
    
        }

        public DbSet<Customer> customers{ get; set; }
        public DbSet<Order> orders{ get; set; }
        public DbSet<Product> product{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProjectMapping());
            base.OnModelCreating(modelBuilder);
        }
    }




}
