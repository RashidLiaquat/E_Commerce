namespace EComDAL.Model
{
    public class AuditFields
    {
        public string CreatedBy { get; set; } = string.Empty;
        public string UpdatedBy { get; set; } = string.Empty;

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;

        public IsDeletedStatus? DeletedBy { get; set; }
    }

}
