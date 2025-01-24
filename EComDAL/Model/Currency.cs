using System.ComponentModel.DataAnnotations;

namespace EComDAL.Model
{
    public class Currency : AuditFields
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Title cannot exceed 50 characters")]
        public string? Title { get; set; }

        public ICollection<Payment> Payment { get; set; } = new List<Payment>();


    }
}
