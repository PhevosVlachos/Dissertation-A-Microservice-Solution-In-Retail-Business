﻿using System.Text.Json.Serialization;

namespace MVC_Solutions_In_Retail.Model
{
    public class Product
    {
  
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        public double  Price { get; set; }

        public int Quantity { get; set; }

        public virtual Supplier ?Supplier { get; set; }
        
        [JsonIgnore]
        public virtual List<MyCatalogue> Catalogues { get; set; }

    }
}
