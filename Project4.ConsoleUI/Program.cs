using Project4.Business;
using Project4.DataAccess;
using System;

namespace Project4.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            try
            {
                productManager.Add(new Entities.Product { ProductId = 10, ProductName = "Laptop", QuantityPerUnit = "4 ayaklı massa", UnitPrice = 5000, UnitsInStock = 3 });

            }
            catch (DuplicateProductException exception)
            {

                Console.WriteLine(exception.Message); 
            }


    }
    }
}