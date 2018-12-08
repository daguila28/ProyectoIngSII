using ProyectoFinal.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Application.DTOS
{
    public class OrdenDto
    {

        public int Id { get; set; }
        public List<Product> Products { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public Customer Customer { get; set; }
        public double Total { get; set; }
    }
}
