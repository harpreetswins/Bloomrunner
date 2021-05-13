using System;
using System.ComponentModel.DataAnnotations;

namespace Admin.Domain.Models.Admin
{
    public class StaffModel
    {
        public int FloristId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string ProfileImage { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public int StateId { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public DateTime Dob { get; set; }
        public int GridPageSize { get; set; }
        public string DefultLocation { get; set; }
        public int HomeScreen { get; set; }
        public string Attributes { get; set; }
        public string Locations { get; set; }
        public string Artists { get; set; }
        public string Roles { get; set; }
        public string UserAttributes { get; set; }
        public string UserLocation { get; set; }
        public string UserArtists { get; set; }
        public string UserRols { get; set; }
        public Guid AuthId { get; set; }
        public bool IsArtist { get; set; }
        public string CreatedBy { get; set; }
    }
    public class StaffModelDerived : StaffModel
    {
        public string StaffId { get; set; }
        public string IsActive { get; set; }
        public string CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
        public string IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public string DeletedDate { get; set; }
    }
    public class StaffDeleteModel
    {
        public int StaffId { get; set; }
        public int FloristId { get; set; }
        public string DeletedBy { get; set; }
    }
    public class StaffUpdateModel
    {
        public int StaffId { get; set; }
        public int FloristId { get; set; }
        public int LocationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Dob { get; set; }
        public int StateId { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public bool IsActive { get; set; }
        public int GridPageSize { get; set; }
        public string DefultLocation { get; set; }
        public int HomeScreen { get; set; }
        public bool IsArtist { get; set; }
        public string ModifiedBy { get; set; }
        public string Attributes { get; set; }
        public string Locations { get; set; }
        public string Artists { get; set; }
        public string Roles { get; set; }
    }

    public class CustomizeGrid
    {
        public int StaffId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public DateTime Dob { get; set; }
        public string RoleName { get; set; }
        public bool IsActive { get; set; }
        public string TotalRows { get; set; }
    }

    public class SearchGrid
    {
        [Required]
        public int FloristId { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public string SearchValue { get; set; }
        public string SortColumn { get; set; }
        public string SortOrder { get; set; }
    }

    public class StaffUpdateStatusModel
    {
        public int StaffId { get; set; }
        public bool IsActive { get; set; }
        public string ModifiedBy { get; set; }
    }

    public class PermissionModel
    {
        public int FloristId { get; set; }
        public int GridPageSize { get; set; }
        public string DefultLocation { get; set; }
        public string ShopName { get; set; }
        public int HomeScreen { get; set; }
        public bool IsArtist { get; set; }
        public int RoleId { get; set; }
        public string Screens { get; set; }
    }
}