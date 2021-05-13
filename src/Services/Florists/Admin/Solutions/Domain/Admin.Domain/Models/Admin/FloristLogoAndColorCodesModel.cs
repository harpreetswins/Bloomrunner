namespace Admin.Domain.Models.Admin
{
    public class FloristLogoAndColorCodesModel
    {
    //public string LogoFile { get; set; }
   // public string MainColor { get; set; }
   // public string ColorCode1 { get; set; }
   // public string ColorCode2 { get; set; }
   // public string ColorCode3 { get; set; }

      public int ThemeId { get; set; }
      public string ThemeName { get; set; }
      public string ThemeColor { get; set; }
      public string Logo { get; set; }
      public string Appcolor { get; set; }
      public string MainColor { get; set; }
    }
     public class FloristLogoandColorSendModel
     {
        public int FloristId { get; set; }
     }
}