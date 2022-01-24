namespace Caroline.Domain.Auditable
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool DeleteFlag { get; set; }

        public BaseEntity()
        {
            CreatedDate = DateTime.UtcNow;
            DeleteFlag = false;
        }
    }
}