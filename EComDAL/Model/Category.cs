using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Model
{
    public class Category : AuditFields
    {
        [Required]
        [StringLength(50, ErrorMessage = "Category Name cannot exceed 50 characters")]
        public string? Category_Name { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "Description cannot exceed 150 characters")]
        public string? Description { get; set; }

        [Required]
        public string? Image { get; set; }

        public SubCategory? SubCategory_Id { get; set; }
    }
}
