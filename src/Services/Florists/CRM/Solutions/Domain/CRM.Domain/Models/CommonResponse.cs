namespace CRM.Domain.Models
{
    public class CommonResponse
    {
        public int KeyId { get; set; }
        public int ResponseCode { get; set; }
        public string ResponseMessage { get; set; }       
    }
    public class CommonResponseOrder : CommonResponse
    {
    public string Email { get; set; }
    public string Name { get; set; }
    public string OrderStatus { get; set; }
    }

    public class DiscountOrderResponse
    {
        public int DiscountId { get; set; }
        public decimal Amount { get; set; }
        public  string Message { get; set; }
    }
}