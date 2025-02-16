namespace EComDAL.Model
{
    public class AuditFields
    {

        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; } = true;
        public IsDeletedStatus? DeletedBy { get; set; }
    }

}
