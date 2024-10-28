using FactoryMethod.Application.Models;
using FactoryMethod.Infrastructure.Payments;
using Microsoft.AspNetCore.Mvc;

namespace FactoryMethod.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        private readonly IPaymentServiceFactory _paymentServiceFactory;
        public OrdersController(IPaymentServiceFactory paymentServiceFactory)
        {
            _paymentServiceFactory = paymentServiceFactory;
        }

        [HttpPost]
        public IActionResult Post(OrderInputModel model)
        {
            var service = _paymentServiceFactory.GetService(model.PaymentInfo.PaymentMethod);

            service.Process(model);

            return NoContent();
        }
    }
}
