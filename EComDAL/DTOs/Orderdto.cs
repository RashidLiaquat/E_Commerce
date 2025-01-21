using EComDAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.DTOs
{
    public class Orderdto : AuditFieldsdto
    {
        public DateTime Order_Date { get; set; } = DateTime.Now;
        public decimal Total_Amount { get; set; }
        public decimal Shipping_Fee { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "Billing cannot exceed 50 characters")]
        public string? Billing_Address { get; set; }
        [Required]
        [StringLength(250, ErrorMessage = "Shipping Address cannot exceed 250 characters")]
        public string? Shipping_Address { get; set; }
        public User? User_Id { get; set; }
        public Status Status { get; set; }
    }
}
