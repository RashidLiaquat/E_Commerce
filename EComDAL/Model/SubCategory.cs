using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Model
{
    public class SubCategory : AuditFields
    {
        [Required]
        [StringLength(100, ErrorMessage = "Sub Category Name cannot exceed 100 characters")]
        public string? Sub_Category_Name { get; set; }
        [Required]
        [StringLength(250, ErrorMessage = "Description cannot exceed 250 characters")]
        public string? Description { get; set; }
        [Required]
        public string? Image { get; set; }
    }
}
