namespace CRM.Domain.Models
{
    public class CustomerActivityCountModel
    {
        public string CustomerStatus { get; set; }
        public int CustomerCount { get; set; }
    }
    public class SearchCustomerActivityCountModel
    {
        public int Days { get; set; }
        public int CustomerId { get; set; }
    }

}