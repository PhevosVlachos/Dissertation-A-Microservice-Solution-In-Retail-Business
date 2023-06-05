using MVC_Solutions_In_Retail.Model;

namespace MVC_Solutions_In_Retail.Services
{
    public interface IProductService
    {
        public void AddProductsToStock(string name, double price, int quantity, string description);

        public List<Product> GetAllProducts();

        public void UpdateProductsByName(string username, double price,int quantity, string description );

        public void DeleteProductsById(int productId);

        public void DeleteProductsByName(string username, int quantity);

        public void RemoveProductEntryByName(string username);

        public void RemoveProductEntryById(int productId);

        public Product GetProductById(int productId);

        public Product GetProductByName(string username);

        
        //void SetProductToSupplier(int id, int supplierId);
    }
}
