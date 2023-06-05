using Cart_System.Data;
using Cart_System.Model;
using Microsoft.EntityFrameworkCore;
using Ordering_System.Client;

namespace Cart_System.Services
{
    public class CartService : ICartService
    {

        private CartDbContext _context;

        public CartService(CartDbContext context)
        {
            _context = context;
        }

        public void AddProductToCart(int customerId, int productId, int quantity)
        {
         
            List<Account> savedCustomers = _context.Customers.ToList();
            Account chosen = new();

            foreach (Account customer in savedCustomers)
            {
                if(customer.Id == customerId)
                {
                    chosen = customer;
                    break;
                }
            }


            List<Cart> savedCarts = _context.Cart.ToList();
            Cart chosenCart = new();

            foreach (Cart cart in savedCarts) 
            {

                if (cart.Customer == chosen) 
                {
                    chosenCart = cart;
                    break;
                }
            
            }



            //List<Product> savedProducts = _context.Products.ToList();
            Product chosenProduct = new Product()
            {
                Id = productId

            };

            //foreach (Product product in savedProducts)
            //{
            //    if (product.Id == productId)
            //    {
            //        chosenProduct = product;

            //    }
            //}




            CartDetails details = new CartDetails()
            {
                Cart = chosenCart,
                Product = chosenProduct,
                Quantity = quantity

            };

            _context.CartDetails.Add(details);
            _context.SaveChanges();
            
        }

        public Account GetCustomer(int customerId) {

            Account customer = new();

            customer = ApiCaller.GetItemAsync<Account>("https://localhost:7231/Account/", $"GetAccountById/{customerId}");
            

            return customer;
        }

     
        public void CreateCart(int customerId)
        {
           
            
            Account customer = ApiCaller.GetItemAsync<Account>("https://localhost:7231/Account/", $"GetAccountById/{customerId}");
     


            Cart cart;
            cart = new Cart()
            {
                Customer = customer
    

            };

            _context.Cart.Add(cart);
            _context.SaveChanges();
            
        }

       

        public List<CartDetails> ReadCartDetails(int customerId)
        {
            Account customer = _context.Customers.Find(customerId);
            List<Cart> carts = _context.Cart.ToList();
            List<CartDetails> detailsContext = _context.CartDetails.Include(d => d.Cart).Include(d => d.Product).ToList();
            List<CartDetails> toReturn = new();

            foreach ( Cart cart in carts)
            {

                if (cart.Customer == customer)
                {

                    foreach (CartDetails details in detailsContext)
                    {

                        if (details.Cart == cart) {
                            
                            toReturn.Add(details);
                           
                        }


                    }

                    break;
                }

             
               

            }


            return toReturn;
            
        }

        

        public void RemoveProductFromCart(int cartId, int productId, int quantity)
        {
            //CartDetails cartDetails = _context
            //      .CartDetails
            //      .FirstOrDefault( c => c.Cart.Id == cartId && c.ProductId == productId);

            //_context.CartDetails.Remove(cartDetails);
            //_context.SaveChanges();

        }

      
    }
}
