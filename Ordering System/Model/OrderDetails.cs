namespace Ordering_System.Model
{
    public class OrderDetails
    {   
         public int Id { get; set; }

         public Order Order { get; set; }
         
         public Product Product { get; set;}

     
    }
}
