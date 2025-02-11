using System.ComponentModel.DataAnnotations;

namespace EComDAL.DTOs
{
    public class Countrydto:AuditFieldsdto
    {
        [Required]
        [StringLength(50, ErrorMessage = "Country Name cannot exceed 50 characters")]
        public string CountryName { get; set; } = string.Empty;
    }
}
