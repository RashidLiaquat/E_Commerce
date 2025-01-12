using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Model
{
    public class OrderItem:AuditFields
    {
        public Order? Order_Id { get; set; }
        public Product? Product_Id { get; set; }

    }
}
