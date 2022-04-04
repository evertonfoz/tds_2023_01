namespace TDS_CA_MS.Application.Products.Commands
{
    public class ProductDeleteCommand : ProductCommand
    {
        public int Id { get; set; }
        public ProductDeleteCommand(int id)
        {
            Id = id;
        }
    }
}
