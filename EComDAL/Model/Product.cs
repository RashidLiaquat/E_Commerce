using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EComDAL.Model
{
    public class Product : AuditFields
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Product Name cannot exceed 100 characters")]
        public string? Product_Name { get; set; }
        [Required]
        [StringLength(250, ErrorMessage = "Description cannot exceed 250 characters")]
        public string? Description { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "SKU cannot exceed 50 characters")]
        public string? SKU { get; set; }
        [Required]
        [Range(0, 99999999.99, ErrorMessage = "Price must be between 0 and 99999999.99")]
        public decimal Price { get; set; }
        [Required]
        [Range(0, 1000000, ErrorMessage = "Stock Quantity must be between 0 and 1,000,000")]
        public int Stock_Quantity { get; set; }
        [Required]
        public string? Image { get; set; }
        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    }
}
