using Microsoft.EntityFrameworkCore;
using TDS_CA_MS.Domain.Entities;
using TDS_CA_MS.Domain.Interfaces;
using TDS_CA_MS.Infra.Data.DataContext;

namespace TDS_CA_MS.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private DataApplicationContext _productContext;
        public ProductRepository(DataApplicationContext context)
        {
            _productContext = context;
        }
        public async Task<Product> CreateAsync(Product product)
        {
            _productContext.Add(product);
            await _productContext.SaveChangesAsync();
            return product;
        }

        public async Task<bool> DeleteAsync(Product product)
        {
            try
            {
                _productContext.Remove(product);
                await _productContext.SaveChangesAsync(true);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<Product?> GetProductByIDAsync(int? id)
        {
            return await _productContext.
                Products.SingleOrDefaultAsync(p => p.ProductID == id);
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _productContext.Products.ToListAsync();
        }

        public async Task UpdateAsync(Product product)
        {
            _productContext.Update(product);
            await _productContext.SaveChangesAsync();
            return;
        }
    }
}
