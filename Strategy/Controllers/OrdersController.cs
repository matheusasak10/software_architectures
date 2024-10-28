using Microsoft.AspNetCore.Mvc;
using Strategy.Application.Models;
using Strategy.Infrastructure.Payments;

namespace Strategy.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : Controller
    {
        [HttpPost]
        public IActionResult ProcessPaymentWithStrategy(OrderInputModel model, [FromServices] IPaymentContext context, [FromServices] IPaymentStrategyFactory factory)
        {
            IPaymentStrategy strategy = factory.GetStrategy(model.PaymentInfo.PaymentMethod);

            var result = context
                .SetStrategy(strategy)
                .Process(model);

            return Ok(result);
        }
    }
}
