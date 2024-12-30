using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PosApp.Data;
using PosApp.Models;

namespace PosApp.Services
{
    public class ProductService
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddOrUpdateProduct(Product product)
        {
            var existingProduct = _dbContext.Products.FirstOrDefault(p => p.Sku == product.Sku);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                _dbContext.Products.Update(existingProduct);
            }
            else
            {
                _dbContext.Products.Add(product);
            }
            _dbContext.SaveChanges();
        }

        public List<Product> GetAllProducts() => _dbContext.Products.ToList();

        public Product? GetProductBySku(string sku)
        {
            return _dbContext.Products.FirstOrDefault(p => p.Sku == sku);
        }
    }
}
