using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Model
{
    public class Cart : AuditFields
    {
        public decimal Total_Amount { get; set; }
        public decimal Discount_Amount { get; set; }
        public decimal ShippingAmount { get; set; }
        public decimal GrandTotal { get; set; }
        public Status CartStatus { get; set; }
        public User? User_Id { get; set; }
    }
}
