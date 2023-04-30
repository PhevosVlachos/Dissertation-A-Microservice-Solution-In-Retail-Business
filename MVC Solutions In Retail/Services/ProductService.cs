using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVC_Solutions_In_Retail.Data;
using MVC_Solutions_In_Retail.DTO;
using MVC_Solutions_In_Retail.Model;
using System.Xml.Linq;

namespace MVC_Solutions_In_Retail.Services
{
    public class ProductService : IProductService
    {
        private CatalogDbContext _context;

        public ProductService(CatalogDbContext context)
        {
            _context = context;
        }

        public void CreateProducts(string name, double price)
        {
            List<Product> products = new List<Product>();


            products.Add(new Product()
            {
                Name =  name,   
                Price = price
            }); 


      
            products.ForEach( p => _context.Products.Add(p));
            _context.SaveChanges();
        }

        public List<Product> GetAllProducts()

        {
            return _context.Products.ToList();
            //return _context.Products.Include(p=> p.Supplier).ToList();
        }

        public void UpdateProducts(int productId, double price) 
        {
            Product product = _context.Products.Find(productId);
            product.Price = price;
            _context.SaveChanges();

        }

        public void DeleteProducts(int productId) 
        {
            Product? product = _context
                 .Products
                 .Find(productId);

            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }

        public Product GetProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public Product GetProductByName(string username)
        {
            throw new NotImplementedException();
        }

        //public void SetProductToSupplier(int productId, int supplierId)
        //{

        //    Product product = _context.Products.Find(productId);
        //    Supplier supplier = _context.Suppliers.Find(supplierId);
        //    product.Supplier = supplier;
        //    _context.SaveChanges();
        //}
    }
}
