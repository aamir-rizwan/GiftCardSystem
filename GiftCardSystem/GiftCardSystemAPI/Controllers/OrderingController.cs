using GiftCardSystemAPI.Models;
using GiftCardSystemAPI.Models.Infrastructure;
using GiftCardSystemAPI.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GiftCardSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderingController : BaseController
    {
        private readonly ILogger<OrderingController> _logger;
        private readonly ICustomerOrder _customerOrder;        

        public OrderingController(ILogger<OrderingController> logger, ICustomerOrder customerOrder)
        {
            _logger = logger;
            _customerOrder = customerOrder;            
        }

        [HttpPost]
        [Route("PlaceOrder")]
        public async Task<ActionResult<ApiResponse<OrderResponse>>> Get(OrderRequest request)
        {
            var result = await this._customerOrder.CreateOrder(request);
            return base.HandleResult(result);
        }

    }
}
