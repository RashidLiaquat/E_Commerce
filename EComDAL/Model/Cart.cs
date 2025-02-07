using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EComDAL.Model
{
    public class Cart : AuditFields
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Total amount cannot be negative")]
        public decimal TotalAmount { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Discount amount cannot be negative")]
        public decimal DiscountAmount { get; set; } = 0;

        [Range(0, double.MaxValue, ErrorMessage = "Shipping amount cannot be negative")]
        public decimal ShippingAmount { get; set; } = 0;

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Grand total cannot be negative")]
        public decimal GrandTotal { get; set; }

        [Required]
        public CartStatus CartStatus { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; } = null!;

        public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    }

}
