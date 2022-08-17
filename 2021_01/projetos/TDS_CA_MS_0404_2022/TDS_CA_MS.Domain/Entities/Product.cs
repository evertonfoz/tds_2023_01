namespace TDS_CA_MS.Domain.Entities
{
    public class Product
    {
        public int ProductID { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }

        public Product(int productID, string description, decimal price)
        {
            ProductID = productID;
            Description = description;
            Price = price;  
        }
    }
}
