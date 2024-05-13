using GiftCardSystemAPI.Models;
using GiftCardSystemAPI.Models.Infrastructure;
using GiftCardSystemAPI.Services.Contracts;

namespace GiftCardSystemAPI.Services.Implementation
{
    public class CustomerOrder : ICustomerOrder
    {
        private readonly ILogger<CustomerOrder> _logger;
        private readonly ICustomerInfo _customerInfo;

        public CustomerOrder(ILogger<CustomerOrder> logger, ICustomerInfo customerInfo)
        {            
            this._logger = logger;
            this._customerInfo = customerInfo;
        }

        public async Task<Result<OrderResponse>> CreateOrder(OrderRequest request)
        {
            var validationResult = OrderRequest.Validate(request);
            if (validationResult.IsFailure)
            {
                var msg = $"Please provide a valid data, {validationResult.Error} ";
                _logger.LogError(msg);
                return Result.Failure<OrderResponse>(msg, StatusCodes.Status404NotFound);
            }
                        
            if(request.Order.CustomerId == null)
            {
                await _customerInfo.CreateNewCustomer(request.Order.Customer); 
            }
            // Call Insert Order 
            // // Call Insert Order Details 

            var result = new OrderResponse()
            {   
                // Populate Response Object
            };
            return Result.Success(result);
        }

        public async Task<Result<OrderResponse>> GetOrder(Guid OrderId)
        {
            // Get Order Info Form Repo 
            var result = new OrderResponse()
            {
            };
            return Result.Success(result);
        }
         
    }
}
