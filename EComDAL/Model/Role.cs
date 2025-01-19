using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Model
{
    public class Role : AuditFields
    {
        [Required]
        [StringLength(100, ErrorMessage = "Role Name cannot exceed 100 characters")]
        public string? Role_Name { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Description cannot exceed 100 characters")]
        public string? Description { get; set; }
        [Required]
        [StringLength(250, ErrorMessage = "Permissions cannot exceed 250 characters")]
        public string? Permissions { get; set; }
    }
}
