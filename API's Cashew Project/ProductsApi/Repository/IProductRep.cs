using ProductsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApi.Repository
{
    public interface IProductRep<Product>
    {
        public List<Product> getAllProducts();
        void AddProduct(Product p);

        void EditProduct(Product p,int id);

        void DeleteProduct(int ProductId);

        Product getProdById(int id);
    }
}
