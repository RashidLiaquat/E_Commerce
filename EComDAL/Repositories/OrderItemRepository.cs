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
            if (orderItemdto == null)
            {
                throw new ArgumentNullException(nameof(orderItemdto), "OrderItem data is null");
            }

            var order = await (_context.Orders?.FirstOrDefaultAsync(c => c.Id == orderItemdto.OrderId.Id && c.IsActive)
                ?? throw new InvalidOperationException("Orders DbSet is null"));

            if (order == null)
            {
                throw new KeyNotFoundException("Order not found or inactive");
            }

            var product = await (_context.Products?.FirstOrDefaultAsync(c => c.Id == orderItemdto.ProductId.Id && c.IsActive)
                ?? throw new InvalidOperationException("Products DbSet is null"));

            if (product == null)
            {
                throw new KeyNotFoundException("Product not found or inactive");
            }

            var orderItem = _mapper.Map<OrderItem>(orderItemdto);

            orderItem.CreatedBy = _genaricRepository.GetCurrentUser()?.UserName
                ?? throw new InvalidOperationException("Current user is null");

            orderItem.CreatedDate = DateTime.Now;

            await _context.Set<OrderItem>().AddAsync(orderItem);

            await _context.SaveChangesAsync();
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
