using GiftCardSystemAPI.Models.Infrastructure;
using GiftCardSystemAPI.Models;
using GiftCardSystemAPI.Services.Contracts;

namespace GiftCardSystemAPI.Services.Implementation
{
    public class CustomerInfo: ICustomerInfo
    {
        private readonly ILogger<CustomerInfo> _logger;
        

        public CustomerInfo(ILogger<CustomerInfo> logger)
        {
            this._logger = logger;           
        }

        public async Task<Result<string>> CreateNewCustomer(Customer request)
        {
            // Create Object in DB
            return Result.Success("Customer Created");
        }

        public async Task<Result<Customer>> GetCustomerById(Guid Id)
        {
            // Get Customer by Id from DataBase 
            var result = new Customer()
            {
            };
            return Result.Success(result);
        }

    }
}
