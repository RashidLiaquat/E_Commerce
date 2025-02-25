using EComDAL.DTOs;
using EComDAL.Model;

namespace EComDAL.Repositories.Interface
{
    public interface IPaymentRepository
    {
        Task<IEnumerable<Payment>> GetAllPayments();
        Task<Payment> GetPaymentById(int Id);
        Task AddPayment(Paymentdto paymentdto);
        Task DeletePayment(int Id);
        Task UpdatePayment(Paymentdto payment, int Id);

    }
}
