using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EComDAL.Model
{
    public class OrderItem : AuditFields
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Range(0, 1000000, ErrorMessage = "Total amount must be between 0 and 1,000,000")]
        public int Quantity { get; set; }
        public decimal Unit_Price { get; set; }
        public decimal Total_Price { get; set; }
        public decimal Discount { get; set; }
        [Required]
        public int OrderId { get; set; }
        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; } = null!;
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;



    }
}
