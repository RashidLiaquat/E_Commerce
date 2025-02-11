using EComDAL.Model;
using System.ComponentModel.DataAnnotations;

namespace EComDAL.DTOs
{
    public class Productdto:AuditFieldsdto
    {
        [Required]
        [StringLength(100, ErrorMessage = "Product Name cannot exceed 100 characters")]
        public string ProductName { get; set; } = string.Empty;
        [Required]
        [StringLength(250, ErrorMessage = "Description cannot exceed 250 characters")]
        public string Description { get; set; } = string.Empty;
        [Required]
        [StringLength(50, ErrorMessage = "SKU cannot exceed 50 characters")]
        public string SKU { get; set; } = string.Empty;
        [Required]
        [Range(0, 99999999.99, ErrorMessage = "Price must be between 0 and 99999999.99")]
        public decimal Price { get; set; }
        [Required]
        [Range(0, 1000000, ErrorMessage = "Stock Quantity must be between 0 and 1,000,000")]
        public int StockQuantity { get; set; }
        [Required]
        public string Image { get; set; } = string.Empty;
        public Category CategoryId { get; set; } = null!;
        public SubCategory SubCategoryId { get; set; } = null!;
    }
}
