using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Model
{
    public class Category:AuditFields
    {
        public string? Category_Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public SubCategory? SubCategory_Id { get; set; }
    }
}
