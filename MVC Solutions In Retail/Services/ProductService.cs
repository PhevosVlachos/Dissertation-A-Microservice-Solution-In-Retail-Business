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

        public void AddProductsToStock(string name, double price, int quantity, string description)
        {
            //List<Product> products = new List<Product>();

            Boolean existsInContext = false;

            List<Product> products = _context.Products.ToList();

            

            Product product;


            if (quantity > 0)
            {
                product = new Product()
                {
                    Name = name,
                    Price = price,
                    Quantity = quantity,
                    Description = description

                };

            }
            else
            {
                product = new Product()
                {
                    Name = name,
                    Price = price,
                    Quantity = 1,
                    Description = description

                };
            }

            foreach(Product p in products) { 
            
                if(p.Name == name)
                {
                    existsInContext = true;
                    product = _context.Products.Find(p.Id);
                    product.Quantity += quantity;
                    _context.SaveChanges();
                    

                }

            }


            //products.Add(new Product()
            //{
            //    Name =  name,   
            //    Price = price,
            //    Quantity = quantity

            //});

            //products.ForEach(p => _context.Products.Add(p));


            if (!existsInContext)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
            }
           
       
        }

        public List<Product> GetAllProducts()

        {
            return _context.Products.ToList();
            //return _context.Products.Include(p=> p.Supplier).ToList();
        }

        public void UpdateProductsById(int productId, double price, int quantity, string description) 
        {
            Product product = _context.Products.Find(productId);

            product.Price = price;
            product.Quantity = quantity;
            product.Description = description;
            
            _context.SaveChanges();

        }

        public void UpdateProductsByName(string username, double price, int quantity, string description)
        {
            Product? product = _context
                  .Products
                  .FirstOrDefault(p => p.Name == username);


            if (quantity > 0)
            {
                product.Quantity = quantity;
               
                _context.SaveChanges();
            }

            if (description != "" ) 
            {
                product.Description = description;

                _context.SaveChanges();
            }

            if (price > 0) 
            {
                product.Price = price;

                _context.SaveChanges();
            }

        }

        public void DeleteProductsById(int productId) 
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

        public void DeleteProductsByName(string username, int quantity)
        {
            Product? product = _context
                 .Products
                 .FirstOrDefault(p => p.Name == username);

            if (product != null && product.Quantity > quantity)
            {
                product.Quantity -= quantity;
             
                _context.SaveChanges();
            }
            else if(product != null && product.Quantity == quantity)
            { 
                
                _context.Products.Remove(product);
                _context.SaveChanges();

            }
            else if (product != null && product.Quantity <= 1 && quantity > 0) {

                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }


        public void RemoveProductEntryByName(string username)
        {
            Product? product = _context
                .Products
                .FirstOrDefault(p => p.Name == username);


            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }

        }


        public void RemoveProductEntryById(int productId) { }

      

        public Product GetProductByName(string username)
        {
            throw new NotImplementedException();
        }

      

        public Product GetProductById(int productId)
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
