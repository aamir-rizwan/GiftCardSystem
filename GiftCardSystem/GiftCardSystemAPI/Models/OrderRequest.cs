using GiftCardSystemAPI.Models.Infrastructure;

namespace GiftCardSystemAPI.Models
{
    public class OrderRequest
    {
        public Order Order { get; set; }
         
        // All Order related information will be included in this class e.g Order, Order Detail, Customer
        // all kind of business validation of any required order attributes will be  applied here
        // we do have required checks on UI as well but it needed on Backend as well

        public static Result Validate(OrderRequest request)
        {
            if (request == null)
                return Result.Failure($"{nameof(OrderRequest)} model is required.");

            // Apply all other required validation here

            return Result.Success();
        }
    }
}
