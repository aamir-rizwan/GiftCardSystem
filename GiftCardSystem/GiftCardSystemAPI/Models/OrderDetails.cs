namespace GiftCardSystemAPI.Models
{
    public class OrderDetails
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid GiftCardId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string GiftCardMessage { get; set; }
        
        public const double GiftCardServiceCost = 2.95;

    }
}
