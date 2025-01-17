using EComDAL.Context;
using EComDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Repositories
{
    internal interface IOrderItemRepository
    {
        IEnumerable<OrderItem> GetAllOrders();
        OrderItem GetOrderById(int id);
        void AddOrder(OrderItem order);
        void UpdateOrder(OrderItem order);
        void DeleteOrder(int id);

    }

    public class OrderitemRepository : IOrderItemRepository
    {
        private readonly DataContext _context;
        public OrderitemRepository(DataContext context)
        {
            _context = context;
        }
        public void AddOrder(OrderItem order)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderItem> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public OrderItem GetOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder(OrderItem order)
        {
            throw new NotImplementedException();
        }
    }
}
