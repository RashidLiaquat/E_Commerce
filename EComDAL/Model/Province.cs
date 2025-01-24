using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Model
{
    public class Province : AuditFields
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Province Name cannot exceed 100 characters")]
        public string? Province_Name { get; set; }

        [Required]
        public int Country_Id { get; set; }

        [ForeignKey(nameof(Country_Id))]
        public Country Country { get; set; } = null!;

        //public ICollection<User> Users { get; set; } = new List<User>();
    }
}
