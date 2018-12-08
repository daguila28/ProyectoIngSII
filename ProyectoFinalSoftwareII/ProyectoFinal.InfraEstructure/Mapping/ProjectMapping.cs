using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ProyectoFinal.Domain.Entidades;

namespace ProyectoFinal.InfraEstructure.Mapping
{
    public class ProjectMapping : EntityTypeConfiguration<Customer>
    {
        public ProjectMapping()
        {
            ToTable("Customer");
            HasKey(p => p.Id);
            Property(p => p.Id).HasColumnName("Id").IsRequired();
            Property(p => p.Name).HasColumnName("Nombre").HasMaxLength(50).IsRequired();
        }
    }
}
