using Artisanal_Services_ProductAPI.Models.Dto;

namespace Artisanal_Services_ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(int productId);
        Task<ProductDto> CreateUpdateProduct(ProductDto productId);

        Task<bool> DeleteProduct(int produitId);



    }
}
