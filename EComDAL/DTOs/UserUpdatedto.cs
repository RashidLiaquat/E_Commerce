using EComDAL.Model;
using System.ComponentModel.DataAnnotations;

namespace EComDAL.DTOs
{
    public class UserUpdatedto
    {
        [Required]
        [StringLength(100, ErrorMessage = "Full Name cannot exceed 100 characters")]
        public string FullName { get; set; } = string.Empty;
        [Required]
        [StringLength(100, ErrorMessage = "User Name cannot exceed 100 characters")]
        public string UserName { get; set; } = string.Empty;
        [Required]
        [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters")]
        public string Email { get; set; } = string.Empty;
        [Required]
        [StringLength(100, ErrorMessage = "Phone Number cannot exceed 100 characters")]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public string ProfilePic { get; set; } = string.Empty;

        [Required]
        [StringLength(250, ErrorMessage = "Address cannot exceed 250 characters")]
        public string Address { get; set; } = string.Empty;
        public int RoleId { get; set; }
        public int ProvinceId { get; set; }

    }
}
