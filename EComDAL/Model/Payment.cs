using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EComDAL.Model
{
    public class Payment : AuditFields
    {
        [Key]
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public PaymentType PaymentMethod { get; set; }
        public PaymentStatus Pay_Status { get; set; }
        public string? TranscationId { get; set; }
        public DateTime Payment_Date { get; set; } = DateTime.Now;
        [Required]
        public int CurrencyId { get; set; }

        [ForeignKey(nameof(CurrencyId))]
        public Currency Currency { get; set; } = null!;
        public string? Remarks { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;

        [Required]
        public int OrderId { get; set; }

        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; } = null!;

    }
}
