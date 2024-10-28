using Strategy.Application.Models;

namespace Strategy.Infrastructure.Payments
{
    public interface IPaymentStrategy
    {
        object Process(OrderInputModel model);
    }
}
