using EComDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.DTOs
{
    public class CartItemdto:AuditFieldsdto
    {
        public int Quantity { get; set; }
        public decimal Unit_Price { get; set; }
        public decimal Discount { get; set; }
        public decimal Total_Price { get; set; }
        public Cart? Cart_Id { get; set; }
        public Product? Product_Id { get; set; }
    }
}
