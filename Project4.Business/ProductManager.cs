using Project4.DataAccess;
using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.Business
{
  public  class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;

        }

        public void Add(Product product)
        {
            if (product.ProductName == "Laptop")
            {
                throw new DuplicateProductException("Laptop ekleyemezsin");
            }
            _productDal.Add(product);
        }

        public List<Product> GetAll()
        {
            EfProductDal productDal = new EfProductDal();

            return _productDal.GetAll();

        }
    }
}

