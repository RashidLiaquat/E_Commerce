using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EComDAL.Model
{
    public class SubCategory : AuditFields
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Sub Category Name cannot exceed 100 characters")]
        public string Sub_Category_Name { get; set; } = string.Empty;

        [Required]
        [StringLength(250, ErrorMessage = "Description cannot exceed 250 characters")]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string Image { get; set; } = string.Empty;

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; } = null!;
    }

}
