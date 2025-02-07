using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EComDAL.Model
{
    public class User : AuditFields
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Full Name cannot exceed 100 characters.")]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [StringLength(100, ErrorMessage = "Username cannot exceed 100 characters.")]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters.")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Phone]
        [StringLength(15, ErrorMessage = "Phone number cannot exceed 15 characters.")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        public Gender GenderStatus { get; set; }

        public string ProfilePic { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$",
            ErrorMessage = "Password must include at least one uppercase letter, one lowercase letter, one number, and one special character.")]
        public string Password { get; set; } = string.Empty;

        [NotMapped] // This ensures the field is not stored in the database
        [Required(ErrorMessage = "Confirm Password is required.")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password must match.")]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Required]
        [StringLength(250, ErrorMessage = "Address cannot exceed 250 characters.")]
        public string Address { get; set; } = string.Empty;

        [Required]
        public int RoleId { get; set; }

        [ForeignKey(nameof(RoleId))]
        public virtual Role Role { get; set; } = null!;

        [Required]
        public int ProvinceId { get; set; }

        [ForeignKey(nameof(ProvinceId))]
        public virtual Province Province { get; set; } = null!;

        public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
