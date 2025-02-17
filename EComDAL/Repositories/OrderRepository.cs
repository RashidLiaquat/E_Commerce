using AutoMapper;
using EComDAL.Context;
using EComDAL.DTOs;
using EComDAL.Model;
using EComDAL.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace EComDAL.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _context;
        private readonly IGenaricRepository _genaricRepository;
        private readonly IMapper _mapper;

        public OrderRepository(DataContext dataContext, IGenaricRepository genaricRepository, IMapper mapper)
        {
            _context = dataContext;
            _genaricRepository = genaricRepository;
            _mapper = mapper;
        }

        public async Task AddOrder(Orderdto orderdto)
        {
            var OrderExists = _context.Orders;
            var CurrentUser = _genaricRepository.GetCurrentUser() ?? throw new InvalidOperationException("Current user is null");

            if (CurrentUser == null)
            {
                throw new KeyNotFoundException($"User is Empty");
            }

            var orders = _mapper.Map<Order>(orderdto);
            if (orders == null)
            {
                throw new KeyNotFoundException("Order not found");
            }

            orderdto.UserId = CurrentUser.Id;

            orderdto.Created_By = CurrentUser.UserName;
            orderdto.Created_Date = DateTime.Now;
            await _context.Set<Order>().AddAsync(orders);
        }

        public async Task DeleteOrder(int id)
        {
            var contex = _context.Orders;
            if (contex == null)
            {
                throw new KeyNotFoundException($"Order context not found");
            }
            var result = await contex.FindAsync();

            if (result == null)
            {
                throw new KeyNotFoundException($"Order not found");
            }

            _context.Set<Order>().Remove(result);
            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Order>> GetAllOrders()
        {
            var result = await (_context.Orders ?? throw new InvalidOperationException("Orders DbSet is null")).Where(x => x.IsActive == true).ToListAsync();
            if (result == null)
            {
                throw new KeyNotFoundException($"Order is empty");
            }
            return result;
        }

        public async Task<Order> GetOrderById(int id)
        {
            var checkcontext = _context.Orders;
            if (checkcontext == null)
            {
                throw new KeyNotFoundException($"Order is empty");
            }
            var result = await checkcontext.Where(o => o.IsActive == true).FirstOrDefaultAsync();
            if (result == null)
            {
                throw new KeyNotFoundException($"Order is empty");
            }
            return result;
        }

        public async Task UpdateOrder(Orderdto orderdto, int id)
        {
            var checkcontext = _context.Orders;
            if (checkcontext == null)
            {
                throw new KeyNotFoundException($"Order is empty");
            }

            var getOrderId = await checkcontext.Where(o => o.IsActive == true && o.Id == id).FirstOrDefaultAsync();
            if (getOrderId == null)
            {
                throw new KeyNotFoundException($"Order is empty");
            }

            _mapper.Map(orderdto, getOrderId);
            orderdto.Updated_By = _genaricRepository.GetCurrentUser()?.UserName ?? throw new InvalidOperationException("Current user is null");
            orderdto.Updated_Date = DateTime.Now;
            _context.Set<Order>().Update(getOrderId);
            await _context.SaveChangesAsync();
        }
    }
}
