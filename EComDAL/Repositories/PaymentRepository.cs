using AutoMapper;
using EComDAL.Context;
using EComDAL.DTOs;
using EComDAL.Model;
using EComDAL.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace EComDAL.Repositories
{
    internal class PaymentRepository : IPaymentRepository
    {
        private readonly DataContext _context;
        private readonly IGenaricRepository _genaricRepository;
        private readonly IMapper _mapper;

        public PaymentRepository(DataContext dataContext, IGenaricRepository genaricRepository, IMapper mapper)
        {
            _context = dataContext;
            _genaricRepository = genaricRepository;
            _mapper = mapper;
        }
        public async Task AddPayment(Paymentdto paymentdto)
        {
            var orderE = _context.Orders;
            var userE = _context.Users;
            var paymentE = _context.Payments;

            if (orderE == null || userE == null || paymentE == null)
            {
                throw new Exception("One or more required tables are empty.");
            }

            var orderExists = await orderE.Where(o => o.Id == paymentdto.OrderId.Id && o.IsActive == true).FirstOrDefaultAsync();
            var userExists = await userE.Where(u => u.Id == paymentdto.UserId.Id && u.IsActive == true).FirstOrDefaultAsync();
            var paymentExists = await paymentE.Where(p => p.Id == paymentdto.Id && p.IsActive == true).FirstOrDefaultAsync();

            if (orderExists == null || userExists == null || paymentExists != null)
            {
                throw new Exception("One or more required entities are not found.");
            }

            var payment = _mapper.Map<Payment>(paymentdto);
            if (payment == null)
            {
                throw new Exception("Payment mapping failed.");
            }
            payment.CreatedBy = _genaricRepository.GetCurrentUser()?.UserName ?? throw new InvalidOperationException("Current user is null");
            payment.CreatedDate = DateTime.Now;
            _context.Set<Payment>().Add(payment);
            await _context.SaveChangesAsync();

        }

        public async Task DeletePayment(int Id)
        {
            var orderE = _context.Orders;
            var userE = _context.Users;
            var paymentE = _context.Payments;

            if (orderE == null || userE == null || paymentE == null)
            {
                throw new Exception("One or more required tables are empty.");
            }

            var payment = await paymentE.Where(p => p.Id == Id && p.IsActive == true)
                .Include(p => p.Order)
                .Include(p => p.User)
                .FirstOrDefaultAsync();
            if (payment == null)
            {
                throw new Exception("Payment not found.");
            }

            _context.Set<Payment>().Remove(payment);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Payment>> GetAllPayment()
        {
            var result = await _context.Set<Payment>()
                .Include(p => p.Order)
                .Include(p => p.User)
                .ToListAsync();
            if (result == null)
            {
                throw new Exception("Payment List Empty.");
            }
            return result;
        }

        public async Task<Payment> GetPaymentById(int Id)
        {
            var result = await _context.Set<Payment>()
                   .Include(p => p.Order)
                   .Include(p => p.User)
                   .Where(p => p.Id == Id && p.IsActive == true)
                   .FirstOrDefaultAsync();
            if (result == null)
            {
                throw new Exception("Payment not found.");
            }

            return result;
        }

        public async Task UpdatePayment(Paymentdto payment, int Id)
        {
            var result = await _context.Payments
                 .Include(p => p.Order)
                 .Include(p => p.User)
                 .Where(p => p.Id == Id && p.IsActive == true)
                 .FirstOrDefaultAsync();
            if (result == null)
            {
                throw new Exception("Payment not found.");
            }
            _mapper.Map(payment, result);
            result.UpdatedBy = _genaricRepository.GetCurrentUser()?.UserName ?? throw new InvalidOperationException("Current user is null");
            result.UpdatedDate = DateTime.Now;
            _context.Set<Payment>().Update(result);
            await _context.SaveChangesAsync();
        }
    }
}
