using EComDAL.DTOs;
using EComDAL.Model;

namespace EComDAL.Repositories.Interface
{
    public interface IOrderItemRepository
    {
        Task<IEnumerable<OrderItem>> GetAllOrderItem();
        Task<OrderItem> GetOrderItemById(int Id);
        Task AddOrderItem(OrderItemdto orderItemdto);
        Task DeleteOrderItem(int Id);
        Task UpdateOrderItem(OrderItemdto orderItem, int Id);
    }
}
