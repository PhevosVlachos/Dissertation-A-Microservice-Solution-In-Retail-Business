using Ordering_System.Model;

namespace Ordering_System.Services
{
    public class OrderService : IOrderService
    {
        public void MakeOrder() {

            List<Product> products = new List<Product>();
            
            List<Order> orders = new List<Order>();

            products.Add(new Product
            {
                Name = "name",

                Description = "description",

                Price = 0.1,

                Quantity = 1
            });

        }

        public String GetProducts() {

            return null;

        }
    }
}
