namespace CRM.Application.DTO.Request
{
    public class RecipientDTO
    {
        public int FloristId { get; set; }
        public int CustomerId { get; set; }
        public string RecipientName { get; set; }
        public string RecipientEmail { get; set; }
        public string RecipientMobileNo { get; set; }
        public int RecipientState { get; set; }
        public string RecipientCity { get; set; }
        public string RecipientZipCode { get; set; }
        public int Relationship { get; set; }
        public string RecipientAddress { get; set; }
        public string CreatedBy { get; set; }
    }
    public class RecipientUpdateDTO
    {
        public int RecipientId { get; set; }
        public int CustomerId { get; set; }
        public int FloristId { get; set; }
        public string RecipientName { get; set; }
        public string RecipientEmail { get; set; }
        public string RecipientMobileNo { get; set; }
        public int RecipientState { get; set; }
        public string RecipientCity { get; set; }
        public string RecipientZipCode { get; set; }
        public int Relationship { get; set; }
        public string RecipientAddress { get; set; }
        public string ModifiedBy { get; set; }

    }
    public class RecipientUpdateStatusDTO
    {
        public int RecipientId { get; set; }
        public bool IsActive { get; set; }
        public string ModifiedBy { get; set; }
    }
}