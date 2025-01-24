using System.ComponentModel.DataAnnotations;

namespace EComDAL.Model
{
    public class Country : AuditFields
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Country Name cannot exceed 50 characters")]
        public string? Country_Name { get; set; }

        //public ICollection<Province> Provinces { get; set; } = new List<Province>();
    }
}
