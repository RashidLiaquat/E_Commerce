using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EComDAL.Model
{
    public class Order : AuditFields
    {
        [Key]
        public int Id { get; set; }
        public DateTime Order_Date { get; set; } = DateTime.Now;
        public decimal Total_Amount { get; set; }
        public decimal Shipping_Fee { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "Billing cannot exceed 50 characters")]
        public string? Billing_Address { get; set; }
        [Required]
        [StringLength(250, ErrorMessage = "Shipping Address cannot exceed 250 characters")]
        public string? Shipping_Address { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; } = null!;
        public Status Status { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
