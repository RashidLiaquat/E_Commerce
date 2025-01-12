using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Model
{
    public class Category:AuditFields
    {
        public SubCategory? SubCategory_Id { get; set; }
    }
}
