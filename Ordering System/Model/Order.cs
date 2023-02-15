namespace Ordering_System.Model
{
    public class Order
    {
        public int OrderId { get; set; }

        public DateTime DateTime { get; set; }

        public List<Product> Products;
    }
}
