using Microsoft.EntityFrameworkCore;
using ProductsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApi.Repository
{
    public class ProdRepo : IProductRep<Product>
    {
        private readonly ShoppingContext db;
        public ProdRepo(ShoppingContext _db)
        {
            db = _db;
        }
        public void AddProduct(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();
        }

        public void DeleteProduct(int ProductId)
        {
            Product p = db.Products.Find(ProductId);
            db.Products.Remove(p);
            db.SaveChanges();
        }

        public void EditProduct(Product p,int id)
        {
            Product p2 = db.Products.Find(id);
            p2.ProductId = p.ProductId;
            p2.ProductImage = p.ProductImage;
            p2.ProductName = p.ProductName;
            p2.ProductPrice = p.ProductPrice;
            p2.ProductDescription = p.ProductDescription;
            db.SaveChanges();
        }

        public List<Product> getAllProducts()
        {
            return db.Products.ToList();
        }

        public Product getProdById(int id)
        {
            Product p = db.Products.Find(id);
            return p;

        }
    }
}
