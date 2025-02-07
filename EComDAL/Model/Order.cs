using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EComDAL.Model
{
    public class Order : AuditFields
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; } = DateTime.Now;

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Total amount must be a positive value.")]
        public decimal TotalAmount { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Shipping fee cannot be negative.")]
        public decimal ShippingFee { get; set; } = 0;

        [Required]
        [StringLength(250, ErrorMessage = "Billing address cannot exceed 250 characters.")]
        public string BillingAddress { get; set; } = string.Empty;

        [Required]
        [StringLength(250, ErrorMessage = "Shipping address cannot exceed 250 characters.")]
        public string ShippingAddress { get; set; } = string.Empty;

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; } = null!;

        [Required]
        public OrderStatus orderStatus { get; set; } = OrderStatus.Pending;

        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
