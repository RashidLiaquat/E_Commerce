using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Model
{
    public class AuditFields
    {
        [Key]
        public int Id { get; set; }
        public string? Created_By { get; set; }
        public string? Updated_By { get; set; }
        public DateTime Created_Date { get; set; } = DateTime.UtcNow;
        public DateTime Updated_Date { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; }
        public IsDeletedStatus DeletedBy { get; set; }

    }
}
