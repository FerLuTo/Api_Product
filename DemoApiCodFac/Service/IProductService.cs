using DemoApiCodFac.Models;

namespace DemoApiCodFac.Service
{
    public interface IProductService
    {
        void CreateProduct(ProductModel product);
        void DeleteProduct(int id);
        List<ProductEntity> GetAllProduct();
        ProductEntity GetProductById(int id);
    }
}