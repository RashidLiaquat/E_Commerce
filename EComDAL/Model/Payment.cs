using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EComDAL.Model
{
    public class Payment : AuditFields
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than zero.")]
        public decimal Amount { get; set; }

        [Required]
        public PaymentType PaymentMethod { get; set; }

        [Required]
        public PaymentStatus PayStatus { get; set; }

        [StringLength(100, ErrorMessage = "Transaction ID cannot exceed 100 characters.")]
        public string TransactionId { get; set; } = string.Empty;

        [Required]
        public DateTime PaymentDate { get; set; } = DateTime.Now;

        [Required]
        public int CurrencyId { get; set; }

        [ForeignKey(nameof(CurrencyId))]
        public virtual Currency Currency { get; set; } = null!;

        [StringLength(500, ErrorMessage = "Remarks cannot exceed 500 characters.")]
        public string Remarks { get; set; } = string.Empty;

        [Required]
        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; } = null!;

        [Required]
        public int OrderId { get; set; }

        [ForeignKey(nameof(OrderId))]
        public virtual Order Order { get; set; } = null!;
    }
}
