using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.DataAccess
{
     public class EfProductDal : IProductDal
    {
        List<Product> _products;
        public EfProductDal()
        {
            _products = new List<Product>
            {

                new Product{ProductId = 1, ProductName ="Acer Bilgisayar", QuantityPerUnit = "32 gb", UnitPrice = 10000, UnitsInStock=12 },
                 new Product{ProductId = 2, ProductName ="Asus Bilgisayar", QuantityPerUnit = "30 gb", UnitPrice = 10000, UnitsInStock=2 },
                new Product{ProductId = 3, ProductName ="EfHp efBilgisayar", QuantityPerUnit = "32 gb", UnitPrice = 10000, UnitsInStock=0 },
                new Product{ProductId = 4, ProductName ="Msi Bilgisayar", QuantityPerUnit = "3 gb", UnitPrice = 10000, UnitsInStock=12 },
                new Product{ProductId = 5, ProductName ="Aser Bilgisayar", QuantityPerUnit = "12 gb", UnitPrice = 10000, UnitsInStock=2 },

            };
        }
        public void Add(Product product)
        {
            throw new Exception("Veritabanına bağlanamadı");
            Console.WriteLine("Entitty ile eklendi");
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
