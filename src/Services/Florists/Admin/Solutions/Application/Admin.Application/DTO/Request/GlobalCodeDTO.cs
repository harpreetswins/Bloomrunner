namespace Admin.Application.DTO.Request
{
    public class GlobalCodeDTO
    {        
        public string CategoryName { get; set; }
        public string CodeName { get; set; }
        public string Description { get; set; }          
        public string CreatedBy { get; set; }    

    }
     public class GlobalCodeDeleteDTO
    {
      public string CategoryName { get; set; }   
      public int GlobalCodeId { get; set; }         
      public string DeletedBy { get; set; }
    }
    public class GlobelcodeUpdateDTO
    {
      public int GlobalCodeId { get; set; }   
      public string CodeName { get; set; }         
      public string Description { get; set; }
      public string ModifiedBy { get; set; }   
    }   
}
