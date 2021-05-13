using System.ComponentModel.DataAnnotations;

namespace AuthIdentityServer.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter email address")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
        public string Message {get;set;}
        public int ThemeId {get;set;}
    }

    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "New Password and Confirm Password does't match")]
        public string ConfirmPassword { get; set; }
        public string Email { get; set; } 
    }
    
}