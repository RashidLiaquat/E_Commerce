using EComDAL.Model;

namespace EComDAL.DTOs
{
    public class CartItemdto:AuditFieldsdto
    {
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }
        public Cart CartId { get; set; } = null!;
        public Product ProductId { get; set; } = null!;
    }
}
