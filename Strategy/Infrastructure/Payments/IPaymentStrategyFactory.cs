using Strategy.Core.Enums;

namespace Strategy.Infrastructure.Payments
{
    public interface IPaymentStrategyFactory
    {
        IPaymentStrategy GetStrategy(PaymentMethod paymentMethod);
    }
}
