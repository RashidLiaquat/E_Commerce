using System.ComponentModel.DataAnnotations;

namespace EComDAL.DTOs
{
    public class SubCategorydto : AuditFieldsdto
    {
        [Required]
        [StringLength(100, ErrorMessage = "Sub Category Name cannot exceed 100 characters")]
        public string Sub_Category_Name { get; set; } = string.Empty;
        [Required]
        [StringLength(250, ErrorMessage = "Description cannot exceed 250 characters")]
        public string Description { get; set; } = string.Empty;
        [Required]
        public string Image { get; set; } = string.Empty;
    }
}
