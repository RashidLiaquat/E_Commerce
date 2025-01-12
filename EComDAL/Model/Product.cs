using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Model
{
    public class Product:AuditFields
    {
        public Category? Category_Id { get; set; }

    }
}
