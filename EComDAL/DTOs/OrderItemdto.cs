using EComDAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.DTOs
{
    public class OrderItemdto : AuditFieldsdto
    {
        [Required]
        [Range(0, 1000000, ErrorMessage = "Total amount must be between 0 and 1,000,000")]
        public int Quantity { get; set; }
        public decimal Unit_Price { get; set; }
        public decimal Total_Price { get; set; }
        public decimal Discount { get; set; }
        public Order? Order_Id { get; set; }
        public Product? Product_Id { get; set; }
    }
}
