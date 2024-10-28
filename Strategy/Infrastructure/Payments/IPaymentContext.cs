using Strategy.Application.Models;

namespace Strategy.Infrastructure.Payments
{
    public interface IPaymentContext
    {
        object Process(OrderInputModel model);
        IPaymentContext SetStrategy(IPaymentStrategy strategy);
    }
}
