namespace Admin.Application.DTO.Request
{
    public class HomeScreenDTO 
    {
        public string ScreenName { get; set; }
        public string ScreenCode { get; set; }
        public string ScreenDescription { get; set; }
        public string CreatedBy { get; set; }
    }
     public class HomeScreenDeleteDTO
    {
      public int ScreenId { get; set; }        
      public string DeletedBy { get; set; }
    }
}