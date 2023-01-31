using MVC_Solutions_In_Retail.Model;

namespace MVC_Solutions_In_Retail.Services
{
    public interface IProductService
    {
        public void MakeProducts();

        public List<Product> ReadProducts();

        void SetProductToSupplier(int id, int supplierId);
    }
}
