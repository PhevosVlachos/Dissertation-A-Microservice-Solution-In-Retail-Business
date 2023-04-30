using MVC_Solutions_In_Retail.Model;

namespace MVC_Solutions_In_Retail.Services
{
    public interface IProductService
    {
        public void CreateProducts(string name, double price);

        public List<Product> GetAllProducts();

        public void UpdateProducts(int productId, double price);

        public void DeleteProducts(int productId);

        public Product GetProductById(int productId);

        public Product GetProductByName(string username);

        
        //void SetProductToSupplier(int id, int supplierId);
    }
}
