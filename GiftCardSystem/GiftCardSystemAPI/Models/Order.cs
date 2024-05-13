using GiftCardSystemAPI.Models.Infrastructure;

namespace GiftCardSystemAPI.Models
{
    public class Order
    {
        public Guid Id { get; set; }        
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public double CreditCardSuCharges { get; set; }
        public bool IsShippingRequired { get; set; }
        public string OrderRecipientAddressId { get; set; }
        public bool StandardDelivery { get; set; }
        public bool ExpressDelivery { get; set; }
        public double DeliveryCharges { get; set; }
        
    }
}
