using System.ComponentModel.DataAnnotations;

namespace EComDAL.DTOs
{
    public class Provincedto:AuditFieldsdto
    {
        [Required]
        [StringLength(100, ErrorMessage = "Province Name cannot exceed 100 characters")]
        public string ProvinceName { get; set; } = string.Empty;
        public int CountryId { get; set; }
    }
}
