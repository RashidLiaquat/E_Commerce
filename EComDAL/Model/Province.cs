using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Model
{
    public class Province : AuditFields
    {
        [Required]
        [StringLength(100, ErrorMessage = "Province Name cannot exceed 100 characters")]
        public string? Province_Name { get; set; }
        public Country? Country_Id { get; set; }
    }
}
