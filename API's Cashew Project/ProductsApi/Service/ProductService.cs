using ProductsApi.Models;
using ProductsApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApi.Service
{
    
    public class ProductService: IServiceRepo<Product>
    {
        private readonly IProductRep<Product> prodrepo;
        public ProductService(IProductRep<Product> pr)
        {
            prodrepo = pr;
        }

        public void AddProduct(Product P)
        {
            prodrepo.AddProduct(P);
        }

        public void DeleteProduct(int id)
        {
            prodrepo.DeleteProduct(id);
        }

        public void EditProduct(Product p,int id)
        {
            prodrepo.EditProduct(p,id);
        }

        public List<Product> getAllProduct()
        {
            return prodrepo.getAllProducts();
        }

        public Product getProdById(int id)
        {
            return prodrepo.getProdById(id);
        }
    }
}
