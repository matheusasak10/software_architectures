using HexagonalArchitecture.AwesomeShop.Domain.Entities;

namespace HexagonalArchitecture.AwesomeShop.Domain.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> GetById(int id);
        Task<List<Order>> GetAll();
        Task<int> Add(Order order);
    }
}
