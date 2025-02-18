using AutoMapper;
using EComDAL.Context;
using EComDAL.DTOs;
using EComDAL.Model;
using EComDAL.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace EComDAL.Repositories
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly DataContext _context;
        private readonly IGenaricRepository _genaricRepository;
        private readonly IMapper _mapper;

        public OrderItemRepository(DataContext dataContext, IGenaricRepository genaricRepository, IMapper mapper)
        {
            _context = dataContext;
            _genaricRepository = genaricRepository;
            _mapper = mapper;
        }
        public async Task AddOrderItem(OrderItemdto orderItemdto)
        {
            var orderExists = _context.Orders;
            var productExists = _context.Products;
            if (orderExists == null)
            {
                throw new KeyNotFoundException("Order is Empty");
            }
            if (productExists == null)
            {
                throw new KeyNotFoundException("Product is Empty");
            }
            var order = await orderExists.AnyAsync(c => c.Id == orderItemdto.OrderId.Id && c.IsActive == true);
            var product = await productExists.AnyAsync(c => c.Id == orderItemdto.ProductId.Id && c.IsActive == true);

            if (order && product)
            {
                var orderItems = _mapper.Map<OrderItem>(orderItemdto);
                if (orderItems == null)
                {
                    throw new KeyNotFoundException("OrderItem not found");
                }
                orderItemdto.Created_By = _genaricRepository.GetCurrentUser()?.UserName ?? throw new InvalidOperationException("Current user is null");
                orderItemdto.Created_Date = DateTime.Now;
                await _context.Set<OrderItem>().AddAsync(orderItems);
            }
            else
            {
                throw new KeyNotFoundException("Order or Product not found");
            }
        }

        public async Task DeleteOrderItem(int Id)
        {
            var ordercontext = _context.OrderItems;
            if (ordercontext == null)
            {
                throw new KeyNotFoundException("OrderItem Context Not found");
            }
            var res = await ordercontext.FindAsync(Id);
            if (res == null)
            {
                throw new KeyNotFoundException("OrderItem Not Found");
            }

            _context.Set<OrderItem>().Remove(res);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<OrderItem>> GetAllOrderItem()
        {
            var result = await _context.Set<OrderItem>()
                .Include(x => x.OrderId)
                .Include(x => x.ProductId)
                .ToListAsync();
            if (result == null)
            {
                throw new KeyNotFoundException("OrderItem List Empty");
            }
            return result;
        }

        public async Task<OrderItem> GetOrderItemById(int Id)
        {
            var result = await _context.Set<OrderItem>()
                .Include(x => x.OrderId)
                .Include(x => x.ProductId)
                .FirstOrDefaultAsync(x => x.Id == Id);
            if (result == null)
            {
                throw new KeyNotFoundException("OrderItem Not Found");
            }

            return result;
        }

        public async Task UpdateOrderItem(OrderItemdto orderItem, int Id)
        {
            var ordercontext = _context.OrderItems;
            if (ordercontext == null)
            {
                throw new KeyNotFoundException("OrderItem Context Not found");
            }
            var result = await ordercontext.Where(o => o.Id == Id && o.IsActive == true).FirstOrDefaultAsync();
            if (result == null)
            {
                throw new KeyNotFoundException("OrderItem Not Found");
            }
            _mapper.Map(orderItem, result);
            orderItem.Updated_By = _genaricRepository.GetCurrentUser()?.UserName ?? throw new InvalidOperationException("Current user is null");
            orderItem.Updated_Date = DateTime.Now;
            _context.Set<OrderItem>().Update(result);
            await _context.SaveChangesAsync();
        }
    }
}
