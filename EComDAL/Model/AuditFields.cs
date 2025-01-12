using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Model
{
    public class AuditFields
    {
        public int Id { get; set; }
        public string? Created_By { get; set; }
        public string? Updated_By { get; set; }
        public DateTime Created_Date { get; set; }
        public DateTime Updated_Date { get;set; }
        public bool IsActive { get; set; }
        public IsDeletedStatus DeletedBy { get; set; }

    }
}
