namespace Ordering_System.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        public double Price { get; set; }

        public int Quantity { get; set; }

       // public virtual Supplier? Supplier { get; set; }

    }
}
