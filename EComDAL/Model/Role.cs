using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Model
{
    public class Role : AuditFields
    {
        public string? Role_Name { get; set; }
        public string? Description { get; set; }
        public string? Permissions { get; set; }
    }
}
