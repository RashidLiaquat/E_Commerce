using EComDAL.Model;
using System.ComponentModel.DataAnnotations;

namespace EComDAL.DTOs
{
    public class Categorydto:AuditFieldsdto
    {
        [Required]
        [StringLength(50, ErrorMessage = "Category Name cannot exceed 50 characters")]
        public string CategoryName { get; set; } = string.Empty;

        [Required]
        [StringLength(150, ErrorMessage = "Description cannot exceed 150 characters")]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string Image { get; set; } = string.Empty;

        public int SubCategoryId { get; set; }
    }
}
