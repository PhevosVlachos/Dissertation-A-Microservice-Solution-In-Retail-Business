using MVC_Solutions_In_Retail.Model;

namespace MVC_Solutions_In_Retail.Services
{
    public class SupplierService : ISupplierService
    {
        public void CreateSuppliers()
        {
            List<Supplier> Suppliers = Enumerable.Range(1, 5).Select(index => new Supplier
            {
                
            })
            .ToList();
        }

        public void DeleteSuppliers()
        {
            throw new NotImplementedException();
        }

        public void GetSuppliers()
        {
            throw new NotImplementedException();
        }

        public void UpdateSuppliers()
        {
            throw new NotImplementedException();
        }
    }
}
