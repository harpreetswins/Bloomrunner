using System;
namespace CRM.Domain.Models
{
    public class FloristDashboardModel
    {
        public decimal FloristRevenue { get; set; }
    }
   
    public class FloristDashboardSearchModel
    {
        public int FloristId { get; set; } 
        public int LocationId { get; set; }   
        public int Days { get; set; } 
        
    }


    public class FloristMonthlyStatsModel
    {
        public int FloristMonth { get; set; }
        public string FloristYear { get; set; }
        public string FloristStatsPeriod { get; set; }
        public decimal OrderAmount { get; set; }
        public decimal AverageCustomerSpending { get; set; }
        public int CustomerCount { get; set; }
    }
   
    public class FloristMonthlyStatsSearchModel
    {
        public int FloristId { get; set; } 
        public string InputDate { get; set; }    
        
    }
    public class FloristCustomersModel
    {
         public int CustomersCount { get; set; }
    }
    public class FloristCustomersSearchModel
    {
        public int FloristId { get; set; }   
        public int LocationId { get; set; }  
        public int Days { get; set; }          
    }
   
}