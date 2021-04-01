using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccsess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product { ProductId = 1, CategoryId = 1, ProductName = "Bardak", UnitePrice = 15, UniteStock = 15 },
                new Product { ProductId = 1, CategoryId = 1, ProductName = "Kamera", UnitePrice = 500, UniteStock = 3 },
                new Product { ProductId = 1, CategoryId = 1, ProductName = "Telefon", UnitePrice = 1500, UniteStock = 2 },
                new Product { ProductId = 1, CategoryId = 1, ProductName = "Klavye", UnitePrice = 150, UniteStock = 65 },
                new Product { ProductId = 1, CategoryId = 1, ProductName = "Fare", UnitePrice = 85, UniteStock = 1 },
            };
        }

   
        public void Add(Product product)
        {

            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = null;
            productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitePrice = product.UnitePrice;
            productToUpdate.UniteStock = product.UniteStock;
        }
    }
}
