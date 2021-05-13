using Admin.Application.DTO.Request;
using BuildingBlocks.Messages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.API.Commands
{
    [MessageNamespace("adminqueue")]
    public class CreateCustomerCommand:ICommand
    {
        public int FloristId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string ProfileImage { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public int StateId { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string Mobile { get; set; }
        public DateTime Dob { get; set; }
        public int GridPageSize { get; set; }
        public string DefultLocation { get; set; }
        public int HomeScreen { get; set; }
        public bool IsArtist { get; set; }
        public string CreatedBy { get; set; }
        public List<StaffAttributesDTO> Attributes { get; set; }
        public List<StaffLocationsDTO> Locations { get; set; }
        public List<StaffArtistsDTO> Artists { get; set; }
        public List<StaffRoleDTO> Roles { get; set; }
        public CreateCustomerCommand() { }

        [JsonConstructor]
        public CreateCustomerCommand(int floristid, string firstname, string lastname, string username, string profileimage,string email,string password,string country,string state,
        string city,string zipCode, string street, string mobile, DateTime dob, int gridpagesize, string defultlocation, int homescreen, bool isArtist, string createdBy, List<StaffAttributesDTO> attributes,
        List<StaffLocationsDTO> locations, List<StaffArtistsDTO> artists, List<StaffRoleDTO> roles)
        {
            FloristId = floristid;
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
            GridPageSize = gridpagesize;
            DefultLocation = defultlocation;
            HomeScreen = homescreen;
            IsArtist = isArtist;
            CreatedBy = createdBy;
            Attributes = attributes;
            Locations = locations;
            Artists = artists;
            Roles = roles;
        }
    }
}
