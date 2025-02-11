using EComDAL.Model;

namespace EComDAL.DTOs
{
    public class Cartdto:AuditFieldsdto
    {
        public decimal TotalAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal ShippingAmount { get; set; }
        public decimal GrandTotal { get; set; }
        public CartStatus CartStatus { get; set; }
        public User UserId { get; set; } = null!;
    }
}
