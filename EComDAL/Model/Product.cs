using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EComDAL.Model
{
    public class Product : AuditFields
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Product Name cannot exceed 100 characters.")]
        public string ProductName { get; set; } = string.Empty;

        [Required]
        [StringLength(250, ErrorMessage = "Description cannot exceed 250 characters.")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [StringLength(50, ErrorMessage = "SKU cannot exceed 50 characters.")]
        public string SKU { get; set; } = string.Empty;

        [Required]
        [Range(0.01, 99999999.99, ErrorMessage = "Price must be between 0.01 and 99,999,999.99.")]
        public decimal Price { get; set; }

        [Required]
        [Range(0, 1_000_000, ErrorMessage = "Stock Quantity must be between 0 and 1,000,000.")]
        public int StockQuantity { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Image URL cannot exceed 500 characters.")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; } = null!;

        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}
