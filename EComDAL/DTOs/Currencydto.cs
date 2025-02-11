using System.ComponentModel.DataAnnotations;

namespace EComDAL.DTOs
{
    public class Currencydto:AuditFieldsdto
    {
        [Required]
        [StringLength(50, ErrorMessage = "Title cannot exceed 50 characters")]
        public string Title { get; set; } = string.Empty;
    }
}
