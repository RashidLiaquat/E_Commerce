using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EComDAL.Model
{
    public class CartItem : AuditFields
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public int Quantity { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Unit price cannot be negative")]
        public decimal UnitPrice { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Discount cannot be negative")]
        public decimal Discount { get; set; } = 0;

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Total price cannot be negative")]
        public decimal TotalPrice { get; set; }

        [Required]
        public int CartId { get; set; }

        [ForeignKey(nameof(CartId))]
        public virtual Cart Cart { get; set; } = null!;

        [Required]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; } = null!;
    }

}
