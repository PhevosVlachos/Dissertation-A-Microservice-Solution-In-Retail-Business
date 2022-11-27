using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVC_Solutions_In_Retail.Data;
using MVC_Solutions_In_Retail.Model;
using System.Xml.Linq;

namespace MVC_Solutions_In_Retail.Services
{
    public class ProductService : IProductService
    {
        private MyDbContext _context;

        public ProductService(MyDbContext context)
        {
            _context = context;
        }

        public void MakeProducts()
        {
            List<Product> products = new List<Product>();


            products.Add(new Product
            {
                Id = products.Count,
                
                Name =  "name",
                
                Description = "description",
                
                Price = 0.1,
                
                Quantity = 1

            }) ; 


           

            products.ForEach( p => _context.Products.Add(p));
            _context.SaveChanges();
        }

        public List<Product> ReadProducts()
        {
            return _context.Products.ToList();
        }
    }
}
