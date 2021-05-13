namespace CRM.Application.DTO.Response
{
    public class CustomerVM
    {
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerMobileNo { get; set; }
        public int CustomerState { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerZipCode { get; set; }
        public string CustomerAddress { get; set; }
        public string BillingAddress { get; set; }
        public bool IsAccountClosed { get; set; }
       // public datetime AccountClosingDate { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedDate { get; set; }  
    }
}