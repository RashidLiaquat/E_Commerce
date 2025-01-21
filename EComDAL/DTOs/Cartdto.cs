using EComDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.DTOs
{
    public class Cartdto:AuditFieldsdto
    {
        public decimal Total_Amount { get; set; }
        public decimal Discount_Amount { get; set; }
        public decimal ShippingAmount { get; set; }
        public decimal GrandTotal { get; set; }
        public Status CartStatus { get; set; }
        public User? User_Id { get; set; }
    }
}
