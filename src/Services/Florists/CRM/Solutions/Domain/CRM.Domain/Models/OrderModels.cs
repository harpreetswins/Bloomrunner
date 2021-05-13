using System;
using System.ComponentModel.DataAnnotations;

namespace CRM.Domain.Models
{
    public class ScheduledOrderCount
    {
        public string TimeSlots { get; set; }
        public string OrderStatus { get; set; }
        public int OrderCount { get; set; }
    }
    public class OrderModels : ScheduledOrderCount
    {
        public int OrderStatusId { get; set; }
        public string StatusColor { get; set; }
        public string StatsIcon { get; set; }
    }
    
    public class SearchScheduledOrder
    {
        public int Days { get; set; }
    }

    public class OrderCountSearch : SearchScheduledOrder
    {
        public int OrderStatus { get; set; }
    }
    public class OrderCountModels 
    {        
        public string OrderHeader { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string OrdersJson { get; set; }
    }

    public class SearchOrderSummery
    {
        public int OrderId { get; set; }
        public int StaffId { get; set; }
        public int FloristId { get; set; }
        public int LocationId { get; set; }
    }

    public class OrderSummeryModel
    {
        public int OrderId { get; set; }
        public int FloristId { get; set; }
        public int LocationId { get; set; }
        public int CustomerSubscriptionPlanId { get; set; }
        public bool isOrderForSelf { get; set; }
        public int RecipientId { get; set; }
        public int OcassionId { get; set; }
        public string Ocassion { get; set; }
        public int ArrangementTypeId { get; set; }
        public string ArrangementType { get; set; }
        public int StyleOfArrangementId { get; set; }
        public string StyleOfArrangement { get; set; }
        public int MoodOfArrangementId { get; set; }
        public string MoodOfArrangement { get; set; }
        public int TimeSlotId { get; set; }
        public string TimeSlot { get; set; }
        public bool IsPickup { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int DiscountCoupon { get; set; }
        public string DiscountCouponName { get; set; }
        public decimal OrderSubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal OrderTotal { get; set; }
        public int OrderStatus { get; set; }
        public string OrderStatusName { get; set; }
        public int BillingType { get; set; }
        public decimal SubcriptionPlanPrice { get; set; }
        public decimal SubcriptionPlanTotalPrice { get; set; }
        public int OrderSizeId { get; set; }
        public string OrderSize { get; set; }
        public int BloomTypeId { get; set; }
        public string BloomType { get; set; }
        public string OrderColors { get; set; }
        public string ArtistNote { get; set; }
        public string CardNote { get; set; }
        public string DriverNote { get; set; }
        public int Customerid { get; set; }
        public string CustomerFirstName { get; set;}
        public string CustomerLastName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerMobileNo { get; set; }
        public int CustomerState { get; set; }
        public string CustomerStateName { get; set; }
        public string CustomerCity { get; set;}
        public string CustomerZipCode { get; set; }
        public string CustomerAddress { get; set; }
        public string BillingAddress { get; set; }
        public string RecipientName { get; set; }
        public string RecipientEmail { get; set; }
        public string RecipientMobileNo { get; set; }
        public string RecipientStateName { get; set; }
        public string RecipientCity { get; set; }
        public string RecipientZipCode { get; set; }
        public string RecipientAddress { get; set; }
        public string OrderDetails { get; set; }
        public string ProductStatus { get; set; } 
    }

    public class CustomerRecipientOrderListModel
    {  
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public int RecipientId { get; set; }
        public string RecipientName { get; set; }
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime Deliverydate { get; set;}
        public string CustomerZipCode { get; set; }
        public string RecipientZipCode { get; set; }
        public string EndTime { get; set; }
        public decimal OrderTotal { get; set; }

    }
    public class SearchOrderListModel : CustomerRecipientOrderListModel
    {
        public int TotalRows { get; set; }
    }


    public class SearchCustomerRecipientOrderList
    {
        [Required]
        public int FloristId { get; set; }
        [Required]
        public int LocationId { get; set; }
        [Required]
        public int Days { get; set; }
        [Required]
        public int OrderStatus { get; set; }
    }

    public class SearchOrderList : SearchCustomerRecipientOrderList
    {
        public int PageNo { get; set; }

         public int PageSize { get; set; }

         public string SearchValue { get; set; }

         public string SortColumn { get; set; }

         public string SortOrder { get; set; }
    }
    public class CreateOrderModel
    {        
        public int FloristId { get; set; }       
        public int LocationId { get; set; }       
        public int CustomerId { get; set; } 
        public int CustomerSubscriptionPlanId { get; set; }    
        public bool isOrderForSelf { get; set; }
        public int RecipientId { get; set; }
        public int Ocassion { get; set; }
        public int ArrangementType { get; set; }
        public int StyleOfArrangement { get; set; }
        public int MoodOfArrangement { get; set; }
        public int TimeSlot { get; set; }
        public bool IsPickup { get; set; }
        //public string OrderDate { get; set; }
        public string DeliveryDate { get; set; }
        public int DiscountCoupon { get; set; }
        public decimal OrderSubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal OrderTotal { get; set; }
         public int BloomType { get; set; }
        [Required]
        public int OrderStatus { get; set; }       
        public int OrderSize { get; set; }
        public int BillingType { get; set; }
        public decimal SubcriptionPlanPrice { get; set; }
        public decimal SubcriptionPlanTotalPrice { get; set; }     
        //public string OrderColors { get; set; }
         public string OrderColors { get; set; } 
        public string ArtistNote { get; set; }
        public string CardNote { get; set; }  
        public string DriverNote { get; set; }
        public string CreatedBy { get; set; }        
        public string OrderDetail { get; set; }

        // Customer Add Model
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerMobileNo { get; set; }
        public int CustomerState { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerZipCode { get; set; }
        public string CustomerAddress { get; set; }
        public string BillingAddress { get; set; }        
    }
    public class ChangeOrderstatusModel
    {
        public int OrderId { get; set; }
        public int OrderStatus { get; set; }
        public string ModifiedBy { get; set; }
    }
    public class DiscountOrderTotalModel
    {
        public decimal OrderTotal { get; set; }
        public int FloristId { get; set; }
        public int CustomerId { get; set; }
        public string DiscountCode { get; set; }
    }

    public class UpdateOrderModel
    {        
        public int OrderId { get; set; } 
        public int FloristId { get; set; }       
        public int LocationId { get; set; }       
        public int CustomerId { get; set; }
        public int CustomerSubscriptionPlanId { get; set; }    
        public bool isOrderForSelf { get; set; }
        public int RecipientId { get; set; }
        public int Ocassion { get; set; }
        public int ArrangementType { get; set; }
        public int StyleOfArrangement { get; set; }
        public int MoodOfArrangement { get; set; }
        public int TimeSlot { get; set; }
        public bool IsPickup { get; set; }  
        public string DeliveryDate { get; set; }
        public int DiscountCoupon { get; set; }
        public decimal OrderSubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal OrderTotal { get; set; }
        public int BloomType { get; set; }        
        public int OrderStatus { get; set; }       
        public int OrderSize { get; set; }
        public int BillingType { get; set; }
        public decimal SubcriptionPlanPrice { get; set; }
        public decimal SubcriptionPlanTotalPrice { get; set; }             
        public string OrderColors { get; set; } 
        public string ArtistNote { get; set; }
        public string CardNote { get; set; }  
        public string DriverNote { get; set; }
        public string ModifiedBy { get; set; }
        // Customer Updated Model
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerMobileNo { get; set; }
        public int CustomerState { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerZipCode { get; set; }
        public string CustomerAddress { get; set; }
        public string BillingAddress { get; set; }       
        public string UpdateOrderDetails { get; set; }
    }
}