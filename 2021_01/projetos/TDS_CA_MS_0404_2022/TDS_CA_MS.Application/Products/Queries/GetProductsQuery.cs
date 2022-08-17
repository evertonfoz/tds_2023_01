using MediatR;
using TDS_CA_MS.Domain.Entities;

namespace TDS_CA_MS.Application.Products.Queries
{
    public class GetProductsQuery : IRequest<IEnumerable<Product>>
    {
    }
}
