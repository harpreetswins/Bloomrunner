using System.Collections.Generic;

namespace CRM.Application.DTO.Request
{
    public class OrderDTO
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
        // customer Add
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerMobileNo { get; set; }
        public int CustomerState { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerZipCode { get; set; }
        public string CustomerAddress { get; set; }
        public string BillingAddress { get; set; }
        //public string OrderColors { get; set; }
        public List<OrderColorsDTO> OrderColors { get; set; }
        public string ArtistNote { get; set; }
        public string CardNote { get; set; }
        public string DriverNote { get; set; }
        public string CreatedBy { get; set; }
        public List<OrderDetailsDTO> OrderDetail { get; set; }
    }
    public class OrderDetailsDTO
    {
        public int ProductId { get; set; }
        public int ProductSize { get; set; }
        public int Quantity { get; set; }
        public decimal ProductPrice { get; set; }

    }
    public class OrderColorsDTO
    {
        public string ColorCode { get; set; }
        public string ColorValue { get; set; }
    }
    public class ChangeOrderstatusDTO
    {
        public int OrderId { get; set; }
        public int OrderStatus { get; set; }
        public string ModifiedBy { get; set; }
    }

    public class UpdateOrderDTO
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
        public string ArtistNote { get; set; }
        public string CardNote { get; set; }
        public string DriverNote { get; set; }
        public string ModifiedBy { get; set; }
        public List<OrderColorsDTO> OrderColors { get; set; }
        // customer Add
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerMobileNo { get; set; }
        public int CustomerState { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerZipCode { get; set; }
        public string CustomerAddress { get; set; }
        public string BillingAddress { get; set; }
        public List<UpdateOrderDetailsDTO> UpdateOrderDetails { get; set; }

    }
    public class UpdateOrderDetailsDTO
    {
        public int OrderDetailsId { get; set; }
        public int ProductId { get; set; }
        public int ProductSize { get; set; }
        public int Quantity { get; set; }
        public decimal ProductPrice { get; set; }
        public bool IsDeleted { get; set; }
    }
}