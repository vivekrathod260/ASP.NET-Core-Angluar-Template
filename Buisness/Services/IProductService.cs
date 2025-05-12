using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buisness.Models;
using Data.Entities;

namespace Buisness.Services
{
    public interface IProductService
    {
        void AddProduct(ProductModel model);
        IEnumerable<Product> GetAllProducts();
    }
}
