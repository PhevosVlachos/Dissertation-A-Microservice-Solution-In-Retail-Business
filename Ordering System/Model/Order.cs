namespace Ordering_System.Model
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public Account Customer { get; set; }
    }
}
