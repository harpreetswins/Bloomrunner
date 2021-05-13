using System;

namespace CRM.Domain.Models
{
    public class CustomerActivityLogModel
    {
        public int CustomerId { get; set; }
        public int ActivityTypeId { get; set; }
        public DateTime LogDate { get; set; }
        public string LogShortDescription { get; set; }
        public string LogDescription { get; set; }
        public string CreatedBy { get; set; }
    }
    public class CustomerActivityLogDerivedModel : CustomerActivityLogModel
    {
        public int CustomerActivityLogId { get; set; }
        public string ActivityType { get; set; }

    }
    public class SearchCustomerActivityLog
    {
        public int CustomerId { get; set; }
    }
}