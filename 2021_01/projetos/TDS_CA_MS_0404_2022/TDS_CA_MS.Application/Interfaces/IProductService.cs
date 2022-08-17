using TDS_CA_MS.Application.DTOs;

namespace TDS_CA_MS.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetProductsAsync();
        Task<ProductDTO> GetProductByIdAsync(int? id);
        Task CreateAsync(ProductDTO productDTO);
        Task UpdateAsync(ProductDTO productDTO);
        Task DeleteAsync(int id);
    }
}
