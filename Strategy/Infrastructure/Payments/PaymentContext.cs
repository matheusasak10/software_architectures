﻿using Strategy.Application.Models;

namespace Strategy.Infrastructure.Payments
{
    public class PaymentContext : IPaymentContext
    {
        private IPaymentStrategy _strategy;
        public object Process(OrderInputModel model)
        {
            var result = _strategy.Process(model);

            return result;
        }

        public IPaymentContext SetStrategy(IPaymentStrategy strategy)
        {
            _strategy = strategy;

            return this;
        }
    }
}
