using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EComDAL.Model
{
    public class Category : AuditFields
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Category Name cannot exceed 50 characters")]
        public string? Category_Name { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "Description cannot exceed 150 characters")]
        public string? Description { get; set; }

        [Required]
        public string? Image { get; set; }

        [Required]
        public int SubCategoryId { get; set; }

        [ForeignKey(nameof(SubCategoryId))]
        public SubCategory SubCategory { get; set; } = null!;

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
