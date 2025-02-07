using System.ComponentModel.DataAnnotations;

namespace EComDAL.Model
{
    public class Country : AuditFields
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Country Name cannot exceed 50 characters")]
        public string CountryName { get; set; } = string.Empty;

        public virtual ICollection<Province> Provinces { get; set; } = new List<Province>();
    }
}
