namespace CRM.Domain.Models
{
    public class CRMClientModel
    {
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }  
        public string CustomerEmail { get; set; } 
        public string CustomerMobileNo { get; set; }  
        public string CustomerCity { get; set; }    
        public string LastPurchaseDate { get; set; }  
        public string Recipients { get; set; }  
        public string Subscriptions { get; set; }  
        public string LTV { get; set; }  
        public string HistoricalOrders { get; set; }
        public string UpcomingOrders { get; set; }  
        public string OrderAmount { get; set; }  
        public string LastConnectDate { get; set; } 
        public bool IsActive { get; set; }  
        public int TotalRows { get; set; } 
        

    }
    public class CRMClientSearchModel
    {
        public int Days { get; set; }
        public int FloristId { get; set; }
        public int CRMCustomerStatusId { get; set; }         
     }
      public class CRMClientListSearchModel
    {
        public int Days { get; set; }
        public int FloristId { get; set; } 
        public int CRMCustomerStatusId { get; set; }
        public int PageNo { get; set; } 
        public int PageSize { get; set; } 
        public string SearchValue { get; set; } 
        public string SortColumn { get; set; }
        public string SortOrder { get; set; }         
    }
}