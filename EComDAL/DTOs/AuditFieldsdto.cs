using EComDAL.Model;
using System.Text.Json.Serialization;

namespace EComDAL.DTOs
{
    public class AuditFieldsdto
    {
        public int Id { get; set; }
        [JsonIgnore]
        public string? Created_By { get; set; }
        [JsonIgnore]
        public string? Updated_By { get; set; }
        [JsonIgnore]
        public DateTime Created_Date { get; set; }
        [JsonIgnore]
        public DateTime Updated_Date { get; set; }
        public bool IsActive { get; set; }

        [JsonIgnore]
        public IsDeletedStatus DeletedBy { get; set; }
    }
}
