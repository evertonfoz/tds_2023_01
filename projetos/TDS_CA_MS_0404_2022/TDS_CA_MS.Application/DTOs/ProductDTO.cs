namespace TDS_CA_MS.Application.DTOs
{
    public class ProductDTO
    {
        public int ProductID { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }

        public ProductDTO(int productID, string description, decimal price)
        {
            ProductID = productID;
            Description = description;
            Price = price;
        }

    }
}
