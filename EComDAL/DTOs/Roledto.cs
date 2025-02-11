using System.ComponentModel.DataAnnotations;

namespace EComDAL.DTOs
{
    public class Roledto : AuditFieldsdto
    {
        [Required]
        [StringLength(100, ErrorMessage = "Role Name cannot exceed 100 characters")]
        public string RoleName { get; set; } = string.Empty;
        [Required]
        [StringLength(100, ErrorMessage = "Description cannot exceed 100 characters")]
        public string Description { get; set; } = string.Empty;
        [Required]
        [StringLength(250, ErrorMessage = "Permissions cannot exceed 250 characters")]
        public string Permissions { get; set; } = string.Empty;
    }
}
