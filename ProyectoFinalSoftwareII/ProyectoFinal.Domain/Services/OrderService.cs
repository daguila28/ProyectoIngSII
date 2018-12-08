using ProyectoFinal.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Domain.Services
{
    public class OrderService
    {
        public static bool IsOrderCorrect(List<Product> products, Order order)
        {

            if (order.Customer == null)
            {
                return false;
            }

            foreach (var product in order.Products)
            {
                if(product == null)
                {
                    return false;
                }
                Product productTemp = products.FirstOrDefault(p => p.Id == product.Id);
                if(productTemp == null)
                {
                    return false;
                }

            }

           

            return true;

        }
    }
}
