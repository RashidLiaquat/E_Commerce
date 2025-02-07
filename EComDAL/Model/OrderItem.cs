using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EComDAL.Model
{
    public class OrderItem : AuditFields
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(1, 1000000, ErrorMessage = "Quantity must be between 1 and 1,000,000.")]
        public int Quantity { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Unit price must be greater than 0.")]
        public decimal UnitPrice { get; set; } = 0;

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Total price cannot be negative.")]
        public decimal TotalPrice { get; set; } = 0;

        [Range(0, double.MaxValue, ErrorMessage = "Discount cannot be negative.")]
        public decimal Discount { get; set; } = 0;

        [Required]
        public int OrderId { get; set; }

        [ForeignKey(nameof(OrderId))]
        public virtual Order Order { get; set; } = null!;

        [Required]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; } = null!;
    }
}
