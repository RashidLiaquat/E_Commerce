namespace EComDAL.Model
{
    public class AuditFields
    {
        public string? Created_By { get; set; }
        public string? Updated_By { get; set; }
        public DateTime Created_Date { get; set; } = DateTime.Now;
        public DateTime Updated_Date { get; set; } = DateTime.Now;
        public bool IsActive { get; set; }
        public IsDeletedStatus DeletedBy { get; set; }

    }
}
