using EComDAL.DTOs;
using EComDAL.Model;

namespace EComDAL.Repositories.Interface
{
    public interface IPaymentRepository
    {
        public Task<IEnumerable<Payment>> GetAllPayment();
        public Task<Payment> GetPaymentById(int Id);
        public Task AddPayment(Paymentdto paymentdto);
        public Task DeletePayment(int Id);
        public Task UpdatePayment(Paymentdto payment, int Id);

    }
}
