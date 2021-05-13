using BuildingBlocks.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.Events
{
    [MessageNamespace("authqueue")]
    public class CustomerCreatedAuthEvent : IEvent
    {
        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string ProfileImage { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string Mobile { get; set; }
        public DateTime Dob { get; set; }

        public CustomerCreatedAuthEvent(int staffId, string firstname, string lastname, string username, string profileimage, string email, string password, string country, string state, 
        string city, string zipCode, string street, string mobile, DateTime dob)
        {
            StaffId = staffId;
            FirstName = firstname;
            LastName = lastname;
            UserName = username;
            ProfileImage = profileimage;
            Email = email;
            Password = password;
            Country = country;
            State = state;
            City = city;
            ZipCode = zipCode;
            Street = street;
            Mobile = mobile;
            Dob = dob;
        }
    }
}
