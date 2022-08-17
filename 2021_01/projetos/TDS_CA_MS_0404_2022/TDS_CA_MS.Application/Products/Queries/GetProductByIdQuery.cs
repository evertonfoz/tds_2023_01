using MediatR;
using TDS_CA_MS.Domain.Entities;

namespace TDS_CA_MS.Application.Products.Queries
{
    public  class GetProductByIdQuery : IRequest<Product>
    {
        public int Id { get; set; }
        public GetProductByIdQuery(int id)
        {
            Id = id;
        }
    }
}
