using System.Collections.Generic;

namespace Admin.Application.DTO.Request
{
    public class ThemeAttributesDTO
    {
        public int FloristId { get; set; }
        public string CreatedBy { get; set; }          
        public List<ThemeAttributesValueDTO> FloristThemeAtt { get; set; } 
    }   
     public class ThemeAttributesValueDTO
     {
        public int FloristThemeAttributeId { get; set; }
        public int ThemeAttributeId { get; set; }
        public string AttributeValue { get; set; }
     }
     
     public class PostThemeAttributeDTO
     {
      public List<PostThemeAttributeValueDTO> ThemeAttributes { get; set; } 
     }

     public class PostThemeAttributeValueDTO
     {
      public int ThemeAttributeId { get; set; }
      public int ThemeId { get; set; } 
      public string AttributeName { get; set; } 
      public string AttributeValue { get; set; } 
      public string AttributeCode { get; set; } 
     }
     public class ApplyFloristThemeAttributeDTO
     {
         public int ThemeId { get; set; }
         public int FloristId { get; set; }
     }

     
     
}