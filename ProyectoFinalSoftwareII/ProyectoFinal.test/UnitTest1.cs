using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinal.Domain.Entidades;
using NUnit;
using System.Collections.Generic;
using ProyectoFinal.Domain.Services;

namespace ProyectoFinal.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldCreateProduct()
        {
            //Arrange
            Product product = new Product(1, "Lubricante 123", "Lubricante", 50.5);

            //Act
            Assert.IsNotNull(product);
            Assert.AreEqual(1, product.Id);
            Assert.AreEqual("Lubricante 123", product.Name);
            Assert.AreEqual("Lubricante", product.Type);
            Assert.AreEqual(50.5, product.Price);
        }

        [TestMethod]
        public void shouldCreateCustomer()
        {
            //Arrange
            Customer customer = new Customer(1, "Dennys");

            Assert.IsNotNull(customer);
        }

        [TestMethod]
        public void shouldCreateOrder()
        {
            //Arrange
            Customer customer = new Customer(1, "Dennys");
            Product product = new Product(1, "Lubricante 123", "Lubricante", 50.5);
            Product product2 = new Product(2, "Lubricante 123", "Lubricante", 50.5);
            List<Product> products = new List<Product>() { product };
            List<Product> products2 = new List<Product>() { product };
            Order order = new Order(1, products2, customer);

            Assert.IsTrue(OrderService.IsOrderCorrect(products, order));
        }

        [TestMethod]
        public void ShouldntCreateOrderWhenAProductIsNull()
        {

            //Arrange
            Customer customer = new Customer(1, "Dennys");
            Product product = new Product(1, "Lubricante 123", "Lubricante", 50.5);
            List<Product> products = new List<Product>() { product, null };
            Order order = new Order(1, products, customer);

            Assert.IsFalse(OrderService.IsOrderCorrect(products, order));
        }

        [TestMethod]
        public void ShouldntCreateOrderWhenAProductDoesNotExist()
        {
            Customer customer = new Customer(1, "Dennys");
            Product product = new Product(1, "Lubricante 123", "Lubricante", 50.5);
            Product product2 = new Product(2, "Lubricante 123", "Lubricante", 50.5);
            List<Product> products = new List<Product>() { product };
            List<Product> products2 = new List<Product>() { product, product2 };
            Order order = new Order(1, products2, customer);

            Assert.IsFalse(OrderService.IsOrderCorrect(products, order));

        }
        [TestMethod]
        public void ShouldntCreateOrderWhenACustomerIsNull()
        {
            Customer customer = new Customer(1, "Dennys");
            Product product = new Product(1, "Lubricante 123", "Lubricante", 50.5);
            List<Product> products = new List<Product>() { product };
            Order order = new Order(1, products, null);

            Assert.IsFalse(OrderService.IsOrderCorrect(products, order));
        }
    }
}
