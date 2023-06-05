using Cart_System.Model;

namespace Cart_System.Services
{
    public interface ICartService
    {
        public void CreateCart(int customerId);

        public void AddProductToCart(int cartId, int productId, int quantity);

        public void RemoveProductFromCart(int cartId, int productId, int quantity);

        public List<CartDetails> ReadCartDetails(int customerId);

        public Account GetCustomer(int customerId);
    }
}
