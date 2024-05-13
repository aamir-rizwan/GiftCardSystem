using GiftCardSystemAPI.Models.Infrastructure;
using GiftCardSystemAPI.Models;

namespace GiftCardSystemAPI.Services.Contracts
{
    public interface ICustomerInfo
    {
        Task<Result<string>> CreateNewCustomer(Customer request);
        Task<Result<Customer>> GetCustomerById(Guid Id);
    }
}
