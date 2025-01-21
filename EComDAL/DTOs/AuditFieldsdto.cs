using EComDAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.DTOs
{
    public class AuditFieldsdto
    {
        [Key]
        public string? Created_By { get; set; }
        public string? Updated_By { get; set; }
        public DateTime Created_Date { get; set; } = DateTime.Now;
        public DateTime Updated_Date { get; set; } = DateTime.Now;
        public bool IsActive { get; set; }
        public IsDeletedStatus DeletedBy { get; set; }
    }
}
