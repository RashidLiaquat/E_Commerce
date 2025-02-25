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
            var orderExists = await _context.Orders.AnyAsync(o => o.Id == paymentdto.OrderId.Id && o.IsActive);
            var userExists = await _context.Users.AnyAsync(u => u.Id == paymentdto.UserId.Id && u.IsActive);
            var currencyExists = await _context.Currencies.AnyAsync(c => c.Id == paymentdto.CurrencyId.Id && c.IsActive);

            if (!orderExists || !userExists || !currencyExists)
            {
                throw new KeyNotFoundException("One or more required entities (Order, User, or Currency) do not exist.");
            }

            var payment = _mapper.Map<Payment>(paymentdto);
            if (payment == null)
            {
                throw new InvalidOperationException("Payment mapping failed.");
            }

            var currentUser = _genaricRepository.GetCurrentUser();
            if (currentUser == null)
            {
                throw new InvalidOperationException("Current user is null.");
            }

            payment.CreatedBy = currentUser.UserName;
            payment.CreatedDate = DateTime.UtcNow;

            await _context.Payments.AddAsync(payment);
            await _context.SaveChangesAsync();
        }


        public async Task DeletePayment(int id)
        {
            var payment = await _context.Payments
                .Include(p => p.Order)
                .Include(p => p.User)
                .Include(p => p.Currency)
                .FirstOrDefaultAsync(p => p.Id == id && p.IsActive);

            if (payment == null)
            {
                throw new KeyNotFoundException($"Payment with ID {id} not found or inactive.");
            }

            if (payment.Order != null)
            {
                throw new InvalidOperationException("Cannot delete payment linked to an active order.");
            }

            _context.Payments.Remove(payment);
            await _context.SaveChangesAsync();
        }


        public async Task<IEnumerable<Payment>> GetAllPayments()
        {
            var payments = await _context.Payments
                .Include(p => p.Order)
                .Include(p => p.User)
                .Include(p => p.Currency)
                .ToListAsync();

            return payments;
        }


        public async Task<Payment> GetPaymentById(int id)
        {
            var result = await _context.Payments
                .Include(p => p.Order)
                .Include(p => p.User)
                .Include(p => p.Currency)
                .FirstOrDefaultAsync(p => p.Id == id && p.IsActive);

            if (result == null)
            {
                throw new KeyNotFoundException($"Payment with ID {id} not found or inactive.");
            }

            return result;
        }


        public async Task UpdatePayment(Paymentdto payment, int Id)
        {
            var result = await _context.Payments
                .Include(o => o.Order)
                .Include(u => u.User)
                .Include(c => c.Currency)
                .FirstOrDefaultAsync(p => p.Id == Id && p.IsActive);

            if (result == null)
            {
                throw new KeyNotFoundException($"Payment with ID {Id} not found or inactive.");
            }

            _mapper.Map(payment, result);

            var currentUser = _genaricRepository.GetCurrentUser();
            if (currentUser == null)
            {
                throw new InvalidOperationException("Current user is null");
            }

            result.UpdatedBy = currentUser.UserName;
            result.UpdatedDate = DateTime.Now;

            await _context.SaveChangesAsync();
        }

    }
}
