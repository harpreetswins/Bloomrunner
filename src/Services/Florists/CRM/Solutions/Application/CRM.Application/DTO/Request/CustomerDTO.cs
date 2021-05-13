namespace CRM.Application.DTO.Request
{
    public class CustomerDTO
    {
        public int FloristId { get; set; }
        public int LocationId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public int Gender { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerMobileNo { get; set; }
        public int CustomerState { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerZipCode { get; set; }
        public string CustomerAddress { get; set; }
        public string BillingAddress { get; set; }
        public bool IsAccountClosed { get; set; }
        public string CreatedBy { get; set; }
    }
    public class CustomerDeleteDTO
    {
        public int CustomerId { get; set; }
        public int FloristId { get; set; }
        public string DeletedBy { get; set; }
    }
    public class CustomerUpdateDTO
    {
        public int CustomerId { get; set; }
        public int FloristId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public int Gender { get; set; }
        public string CustomerMobileNo { get; set; }
        public int CustomerState { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerZipCode { get; set; }
        public string CustomerAddress { get; set; }
        public string BillingAddress { get; set; }
        public string ModifiedBy { get; set; }
    }
    public class CustomerUpdateStatusDTO
    {
        public int CustomerId { get; set; }
        public bool IsActive { get; set; }
        public string ModifiedBy { get; set; }
    }
}