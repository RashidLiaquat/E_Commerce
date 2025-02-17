using EComDAL.DTOs;
using EComDAL.Model;

namespace EComDAL.Repositories.Interface
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetAllOrders();
        Task<Order> GetOrderById(int id);
        Task AddOrder(Orderdto orderdto);
        Task DeleteOrder(int id);
        Task UpdateOrder(Orderdto orderdto, int id);
    }
}
