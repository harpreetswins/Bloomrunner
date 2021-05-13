using System;
using System.Collections.Generic;

namespace Admin.Application.DTO.Response
{    
    public class StaffVM
    {
    public int Id { get; set; }
    public string FloristId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string Mobile { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }     
    public string Dob { get; set; }
    //public string RoleId { get; set; }
    //public string RoleName { get; set; }
    public string GridPageSize { get; set; }
   // public string Location { get; set; }
    public string DefultLocation { get; set; }
    public string HomeScreen { get; set; }
   // public string Note { get; set; }
    public string CreatedBy { get; set; }
    public string CreateDate { get; set; }
    public string ModifiedBy { get; set; }
    public string ModifiedDate { get; set; }
    public string DeletedBy { get; set; }
    public string DeleteDate { get; set; }
    public string IsActive { get; set; }
    public string IsDeleted { get; set; }
    public IEnumerable<UserValueResponse> UserValue {get;set;}
    }
    public class UserValueResponse
    {  
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string YearsOfExperience { get; set; }
    public string FavouriteStyles { get; set; }
    public string About { get; set; } 

    public int UserLocationId { get; set; }
    public int LocationId { get; set; }
    public int UserRollId { get; set; }
    public int RoleId { get; set; }

    }
    
    
}