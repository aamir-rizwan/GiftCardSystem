using GiftCardSystemAPI.Models;
using GiftCardSystemAPI.Models.Infrastructure;

namespace GiftCardSystemAPI.Services.Contracts
{
    public interface ICustomerOrder
    {
        Task<Result<OrderResponse>> CreateOrder(OrderRequest request);

        Task<Result<OrderResponse>> GetOrder(Guid OrderId);
    }
}
