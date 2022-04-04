using TDS_CA_MS.Application.DTOs;
using TDS_CA_MS.Application.Interfaces;

namespace TDS_CA_MS.Application.Services
{
    public class ProductService : IProductService
    {
        public Task CreateAsync(ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDTO> GetProductByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDTO>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }
    }
}
