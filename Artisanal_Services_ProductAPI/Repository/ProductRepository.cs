using Artisanal_Services_ProductAPI.Models;
using Artisanal_Services_ProductAPI.Models.Dto;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Artisanal_Services_ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public ProductRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ProductDto> CreateUpdateProduct(ProductDto productDto)
        {
            Product product = _mapper.Map<ProductDto, Product>(productDto);
            if ( product.ProductId > 0){
                _db.Products.Update(product);
            }
            else
            {
                _db.Products.Add(product);
            }
            await _db.SaveChangesAsync();
            return _mapper.Map<Product,ProductDto>(product);
        }

        public Task<bool> DeleteProduct(int produitId)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductDto> GetProductById(int productId)
        {
            Product product = await _db.Products.Where(p => p.ProductId == productId).FirstOrDefaultAsync();

            return _mapper.Map<ProductDto>(product);
        }

        public  async Task<IEnumerable<ProductDto>> GetProducts()
        {
            List<Product> productList = await  _db.Products.ToListAsync();
            return  _mapper.Map<List<ProductDto>>(productList);
           
        }
    }
}
