using System.ComponentModel.DataAnnotations;
using System;
namespace Admin.Domain.Models.Admin
{
    public class ThemeAttributesModel
    {
    [Required]
    public int FloristId { get; set; }
    [Required]
    public int ThemeId { get; set; }
    }
    public class ThemeAttributesDrivedModel
    {
        public int ThemeAttributeId { get; set; }
        public int ThemeId { get; set; }
        public string AttributeValue { get; set; }
        public string AttributeName { get; set; } 
        public string AttributeCode { get; set; }   
        public int FloristThemeAttributeId { get; set; }     
    }  
    public class ThemeAttributesSaveModel
    {   
        public int FloristId { get; set; }
        public string CreatedBy { get; set; }          
        public string FloristThemeAtt { get; set; }       
    }  
    public class GetThemeModel
     {
         public int ThemeId { get; set; }
         public string ThemeName {get; set;}
         public string ThemeColor { get; set; }
     }
     public class PostThemeAttributeModel
     {
      public string ThemeAttributes { get; set; }
     }

     public class ApplyFloristThemeAttributeModel
     {
         public int ThemeId { get; set; }
         public int FloristId { get; set; }
     }

}