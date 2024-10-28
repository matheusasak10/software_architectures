using FactoryMethod.Infrastructure.Payments;

namespace FactoryMethod
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddUseCases();

            return services;
        }

        private static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddScoped<IPaymentServiceFactory, PaymentServiceFactory>();
            services.AddScoped<CreditCardService, CreditCardService>();
            services.AddScoped<PaymentSlipService, PaymentSlipService>();

            return services;
        }
    }
}
