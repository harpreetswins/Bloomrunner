using System.ComponentModel.DataAnnotations;

namespace AuthIdentityServer.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "Please enter email address")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
