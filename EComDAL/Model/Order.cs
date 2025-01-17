using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Model
{
    public class Order : AuditFields
    {
        public DateTime Order_Date { get; set; }
        public decimal Total_Amount { get; set; }
        public decimal Shipping_Fee { get; set; }
        public string? Billing_Address { get; set; }
        public string? Shipping_Address { get; set; }
        public User? User_Id { get; set; }
        public Status Status { get; set; }

    }
}
