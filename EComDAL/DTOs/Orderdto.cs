using EComDAL.Model;
using System.ComponentModel.DataAnnotations;

namespace EComDAL.DTOs
{
    public class Orderdto : AuditFieldsdto
    {
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public decimal TotalAmount { get; set; }
        public decimal ShippingFee { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "Billing cannot exceed 50 characters")]
        public string Billing_Address { get; set; } = string.Empty;
        [Required]
        [StringLength(250, ErrorMessage = "Shipping Address cannot exceed 250 characters")]
        public string Shipping_Address { get; set; } = string.Empty;
        public User UserId { get; set; } = null!;
        public OrderStatus Status { get; set; }
    }
}
