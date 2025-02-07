using System.ComponentModel.DataAnnotations;

namespace EComDAL.Model
{
    public class Role : AuditFields
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Role name cannot exceed 100 characters.")]
        public string RoleName { get; set; } = string.Empty;

        [Required]
        [StringLength(250, ErrorMessage = "Description cannot exceed 250 characters.")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [StringLength(500, ErrorMessage = "Permissions cannot exceed 500 characters.")]
        public string Permissions { get; set; } = string.Empty;

        public virtual ICollection<User> Users { get; set; } = new List<User>();
    }
}
