using EComDAL.Model;
using System.ComponentModel.DataAnnotations;

namespace EComDAL.DTOs
{
    public class AuditFieldsdto
    {
  
        public string Created_By { get; set; } = string.Empty;
        public string Updated_By { get; set; } = string.Empty;
        public DateTime Created_Date { get; set; } = DateTime.Now;
        public DateTime Updated_Date { get; set; } = DateTime.Now;
        public bool IsActive { get; set; }
        public IsDeletedStatus DeletedBy { get; set; }
    }
}
