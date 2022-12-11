using System.Text.Json.Serialization;

namespace MVC_Solutions_In_Retail.Model
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        [JsonIgnore]
        public virtual List<Product> Products { get; set; }


    
    }
}
