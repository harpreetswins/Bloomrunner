using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AuthIdentityServer.Models.AccountViewModels
{
    public class RegisterDTO
    {
        /****** Basic information *******/
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string ProfileImage { get; set; }
        /****** Credientials *******/
        public string Email { get; set; }
        public string Password { get; set; }
        /****** Address *******/
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
      //   public class RegisterDTODerived : RegisterDTO
      //  {
      //   public string Id { get; set; }
      // }

    }
}
