using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Model
{
    public class User : AuditFields
    {
        [Required]
        [StringLength(100, ErrorMessage = "Full Name cannot exceed 100 characters")]
        public string? Full_Name { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "User Name cannot exceed 100 characters")]
        public string? User_Name { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters")]
        public string? Email { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Phone Number cannot exceed 100 characters")]
        public string? Phone_Number { get; set; }
        [Required]
        public bool Gender { get; set; }
        [Required]
        public string? Profile_Pic { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
        [RegularExpression(@"^(?=.[a-z])(?=.[A-Z])(?=.\d)(?=.[@$!%?&])[A-Za-z\d@$!%?&]{8,}$",
        ErrorMessage = "Password must be strong: include at least one uppercase letter, one lowercase letter, one number, and one special character")]
        public string? Password { get; set; }

        [NotMapped] // This ensures the field is not saved in the database
        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password must match")]
        public string? Confirm_Password { get; set; }
        [Required]
        [StringLength(250, ErrorMessage = "Address cannot exceed 250 characters")]
        public string? Address { get; set; }
        public Role? Role_Id { get; set; }
        public Province? Province_Id { get; set; }

    }
}
