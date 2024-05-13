namespace GiftCardSystemAPI.Models
{
    public class OrderRecipientAddress
    {
        public Guid AddressId { get; set; }
        public string HomeAddress { get; set; }
        public string Street { get; set; }
        public string Suberb { get; set; }
        public string PostCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

    }
}
