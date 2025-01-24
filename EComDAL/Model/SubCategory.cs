using System.ComponentModel.DataAnnotations;

namespace EComDAL.Model
{
    public class SubCategory : AuditFields
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Sub Category Name cannot exceed 100 characters")]
        public string? Sub_Category_Name { get; set; }
        [Required]
        [StringLength(250, ErrorMessage = "Description cannot exceed 250 characters")]
        public string? Description { get; set; }
        [Required]
        public string? Image { get; set; }

        public ICollection<Category> Categories { get; set; } = new List<Category>();
    }
}
