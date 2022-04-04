using MediatR;
using TDS_CA_MS.Domain.Entities;

namespace TDS_CA_MS.Application.Products.Commands
{
    public abstract class ProductCommand : IRequest<Product>
    {
        public int ProductID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
