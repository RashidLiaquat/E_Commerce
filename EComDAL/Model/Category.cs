using System.ComponentModel.DataAnnotations;

namespace EComDAL.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Category Name cannot exceed 50 characters")]
        public string CategoryName { get; set; } = string.Empty;

        [Required]
        [StringLength(150, ErrorMessage = "Description cannot exceed 150 characters")]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string Image { get; set; } = string.Empty;

        // One-to-Many Relationship
        public virtual ICollection<SubCategory> SubCategories { get; set; } = new List<SubCategory>();

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }


}
