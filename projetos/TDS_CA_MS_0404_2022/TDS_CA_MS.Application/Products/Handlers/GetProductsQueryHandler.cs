using MediatR;
using TDS_CA_MS.Application.Products.Queries;
using TDS_CA_MS.Domain.Entities;
using TDS_CA_MS.Domain.Interfaces;

namespace TDS_CA_MS.Application.Products.Handlers
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
    {
        private readonly IProductRepository _productRepository;
        public GetProductsQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IEnumerable<Product>>   Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            return await _productRepository.GetProductsAsync();
        }
    }
}
