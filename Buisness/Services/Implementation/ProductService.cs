using Buisness.Models;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products = new();

        public void AddProduct(ProductModel model)
        {
            var product = new Product
            {
                Id = _products.Count + 1,
                Name = model.Name,
                Price = model.Price
            };
            _products.Add(product);
        }

        public IEnumerable<Product> GetAllProducts() => _products;
    }
}
