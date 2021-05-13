using System.Collections.Generic;

namespace Admin.Application.DTO.Request
{
    public class StaffOrderDTO
    {
        /******************* Insert Staff ******************/
        public int FloristId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Dob { get; set; }
        public int StateId { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public int GridPageSize { get; set; }
        public string DefultLocation { get; set; }
        public int HomeScreen { get; set; }
        public bool IsArtist { get; set; }
        public string CreatedBy { get; set; }
        public List<StaffAttributesDTO> Attributes { get; set; }
        public List<StaffLocationsDTO> Locations { get; set; }
        public List<StaffArtistsDTO> Artists { get; set; }
        public List<StaffRoleDTO> Roles { get; set; }
    }
    public class StaffLocationsDTO
    {
        public int LocationId { get; set; }
    }
    public class StaffArtistsDTO
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string YearsOfExperience { get; set; }
        public List<FavouriteStylesDTO> Styles { get; set; }
        public string About { get; set; }
    }
    public class StaffRoleDTO
    {
        public int RoleId { get; set; }
    }
    public class FavouriteStylesDTO
    {
        public string favouriteStyles { get; set; }
    }
    public class StaffAttributesDTO
    {
        public string AttributesName { get; set; }
        public string AttributesValue { get; set; }
        public bool Tag { get; set; }
    }
    /************************************************/

    /******************* Delete Staff ******************/
    public class StaffDeleteDTO
    {
        public int StaffId { get; set; }
        public int FloristId { get; set; }
        public string DeletedBy { get; set; }
    }
    /************************************************/

    /******************* Update Staff ******************/
    public class StaffUpdateDTO
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
        public List<StaffUpdateAttributesDTO> Attributes { get; set; }
        public List<StaffUpdateLocationsDTO> Locations { get; set; }
        public List<StaffUpdateArtistsDTO> Artists { get; set; }
        public List<StaffUpdateRoleDTO> Roles { get; set; }
    }
    public class StaffUpdateAttributesDTO : StaffAttributesDTO
    {
        public int AttributeId { get; set; }
    }
    public class StaffUpdateLocationsDTO
    {
        public int StaffLocationId { get; set; }        
    }

    public class StaffUpdateArtistsDTO : StaffArtistsDTO
    {
        public int ArtistId { get; set; }
    }
    public class StaffUpdateRoleDTO : StaffRoleDTO
    {
        public int StaffRollId { get; set; }
    }
    /************************************************/


}