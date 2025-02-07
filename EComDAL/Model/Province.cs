using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EComDAL.Model
{
    public class Province : AuditFields
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Province name cannot exceed 100 characters.")]
        public string ProvinceName { get; set; } = string.Empty;

        [Required]
        public int CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]
        public virtual Country Country { get; set; } = null!;

        public virtual ICollection<User> Users { get; set; } = new List<User>();
    }
}
