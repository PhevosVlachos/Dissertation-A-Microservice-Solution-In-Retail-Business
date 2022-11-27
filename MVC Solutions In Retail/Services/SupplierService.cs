using MVC_Solutions_In_Retail.Data;
using MVC_Solutions_In_Retail.Model;

namespace MVC_Solutions_In_Retail.Services
{
    public class SupplierService : ISupplierService
    {

        private MyDbContext _context;
        private IProductService _productService;
        

        public SupplierService(MyDbContext context, IProductService products)
        {
            _context = context;
            _productService = products;
        }

        public void MakeSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();

            

            

            suppliers.Add(new Supplier
            {
                Id = suppliers.Count,
                Products = _productService.ReadProducts()
        }) ;

           suppliers.ForEach(s => _context.Suppliers.Add(s));
            _context.SaveChanges();
        }

       

        public List<Supplier> ReadSuppliers()
        {
            return _context.Suppliers.ToList();
        }

      
    }
}
