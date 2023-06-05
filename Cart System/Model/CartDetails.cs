using Microsoft.EntityFrameworkCore;

namespace Cart_System.Model
{
  
    public class CartDetails
    {
        public int Id { get; set; }

        public Product? Product { get; set; }

        public int Quantity { get; set; }

        public Cart? Cart { get; set; }

       
    }
}
