using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Model
{
    public class OrderItem : AuditFields
    {
        public int Quantity { get; set; }
        public decimal Unit_Price { get; set; }
        public decimal Total_Price { get; set; }
        public decimal Discount { get; set; }
        public Order? Order_Id { get; set; }
        public Product? Product_Id { get; set; }

    }
}
