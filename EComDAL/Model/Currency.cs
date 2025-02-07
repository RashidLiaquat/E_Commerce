using System.ComponentModel.DataAnnotations;

namespace EComDAL.Model
{
    public class Currency : AuditFields
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Title must be between 2 and 50 characters.")]
        public string Title { get; set; } = string.Empty;

        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();


    }
}
