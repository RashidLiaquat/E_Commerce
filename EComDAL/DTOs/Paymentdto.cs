using EComDAL.Model;

namespace EComDAL.DTOs
{
    public class Paymentdto : AuditFieldsdto
    {
        public decimal Amount { get; set; }
        public PaymentType PaymentMethod { get; set; }
        public PaymentStatus Pay_Status { get; set; }
        public string TranscationId { get; set; } = string.Empty;
        public DateTime Payment_Date { get; set; } = DateTime.Now;
        public Currency CurrencyId { get; set; } = null!;
        public string Remarks { get; set; } = string.Empty;
        public User UserId { get; set; } = null!;
        public Order OrderId { get; set; } = null!;
    }
}
