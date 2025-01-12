using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Model
{
    public class User:AuditFields
    {
        public Role? Role_Id { get; set; }
        public Country? Country_Id { get; set; }


    }
}
