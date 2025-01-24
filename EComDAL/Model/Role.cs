using System.ComponentModel.DataAnnotations;

namespace EComDAL.Model
{
    public class Role : AuditFields
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Role Name cannot exceed 100 characters")]
        public string? Role_Name { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Description cannot exceed 100 characters")]
        public string? Description { get; set; }
        [Required]
        [StringLength(250, ErrorMessage = "Permissions cannot exceed 250 characters")]
        public string? Permissions { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
