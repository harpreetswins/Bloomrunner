namespace CRM.Domain.Models
{
    public class CRMRecipientModel
    {
        public int RecipientId { get; set; }
        public int CustomerId { get; set; }
        public int FloristId { get; set; }        
        public string RecipientName { get; set; }        
        public string RecipientMobileNo { get; set; }  
        public string RecipientCity { get; set; }  
        public string RecipientEmail { get; set; }
        public string IsOurCustomer  { get; set; }    
        public string Orders { get; set; }  
        public string LastConnect { get; set; }  
        public string StateName { get; set; }  
        public string StateCodes { get; set; }  
        public string RecipientAddress { get; set; } 
        public bool IsActive { get; set; }    
        public int TotalRows { get; set; }            
    }
    public class CRMRecipientSearchModel
    {
        public int Days { get; set; }
        public int FloristId { get; set; }        
    }

    public class CRMRecipientListSearchModel
    {
       public int Days { get; set; }
        public int FloristId { get; set; } 
        public int PageNo { get; set; } 
        public int PageSize { get; set; } 
        public string SearchValue { get; set; } 
        public string SortColumn { get; set; }
        public string SortOrder { get; set; }        
    }
    public class CrmRecipientUpcommingOrderModel
    {
        
    }


}