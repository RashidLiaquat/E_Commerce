using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Model
{
    public class Currency : AuditFields
    {
        [Required]
        [StringLength(50, ErrorMessage = "Title cannot exceed 50 characters")]
        public string? Title { get; set; }
    }
}
