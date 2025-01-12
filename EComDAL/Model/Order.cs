using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Model
{
    public class Order:AuditFields
    {
        public User? User_Id { get; set; }

    }
}
