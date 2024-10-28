using HexagonalArchitecture.AwesomeShop.Domain.Entities;
using HexagonalArchitecture.AwesomeShop.Domain.Repositories;

namespace FactoryMethod.Infrastructure.Payments
{
    public class OrderRepository : IOrderRepository
    {
        // Adapter que se comunica com o Banco de Dados
        public Task<int> Add(Order order)
        {
            OrderExtensions.AddOrder(order);
            return Task.FromResult(order.Id);
        }

        public Task<List<Order>> GetAll()
        {
            var orders = OrderExtensions.OrderList();
            return Task.FromResult(orders);
        }

        public Task<Order> GetById(int id)
        {
            var order = OrderExtensions.OrderList().FirstOrDefault(x => x.OrderCode == id.ToString());
#pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.
            return Task.FromResult(order);
#pragma warning restore CS8619 // Nullability of reference types in value doesn't match target type.
        }
    }

    public static class OrderExtensions
    {
        static List<Order> orders = new List<Order>() 
        { 
            new Order("1234", "LuisDev", "luisdev@mail.com", new List<OrderItem> { new OrderItem(1, "Product 1", 10.5m, 3) }) ,
            new Order("1235", "LuisDev2", "luisdev2@mail.com", new List<OrderItem> { new OrderItem(1, "Product 2", 11.5m, 4) })
        };

        public static List<Order> OrderList()
        {
            return orders;
        }

        public static void AddOrder(Order order)
        {
            orders.Add(order);
        }
    }
}
