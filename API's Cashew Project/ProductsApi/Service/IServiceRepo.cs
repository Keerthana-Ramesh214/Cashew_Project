using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApi.Service
{
    public interface IServiceRepo<Product>
    {
        void AddProduct(Product P);
        public List<Product> getAllProduct();
        void DeleteProduct(int id);
        void EditProduct(Product p,int id);
        Product getProdById(int id);
    }
}
