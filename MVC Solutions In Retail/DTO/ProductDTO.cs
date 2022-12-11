using MVC_Solutions_In_Retail.Model;

namespace MVC_Solutions_In_Retail.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        public double Price { get; set; }

        public int Quantity { get; set; }

        public int SupplierId { get; set; }

         
    }
}
