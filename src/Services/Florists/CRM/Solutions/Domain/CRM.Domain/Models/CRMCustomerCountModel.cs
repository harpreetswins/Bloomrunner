namespace CRM.Domain.Models
{
    public class CRMCustomerCountModel
    {
         public int GlobalCodeId { get; set; }
         public string CustomerStatus { get; set; }
         public string CustomerCount { get; set; }
         public string StatusColor { get; set; }
         public string StatsIcon { get; set; }
    }
    public class CRMCustomerCountSearchModel
    {
        public int Days { get; set; }
        public int FloristId { get; set; }        
    }
}