using Strategy.Application.Models;

namespace Strategy.Infrastructure.Payments
{
    public class PaymentSlipStrategy : IPaymentStrategy
    {
        public object Process(OrderInputModel model)
        {
            return "Dados do Boleto: xyz";
        }
    }
}
