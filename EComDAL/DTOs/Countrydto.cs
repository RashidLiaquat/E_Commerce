using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.DTOs
{
    public class Countrydto:AuditFieldsdto
    {
        [Required]
        [StringLength(50, ErrorMessage = "Country Name cannot exceed 50 characters")]
        public string? Country_Name { get; set; }
    }
}
