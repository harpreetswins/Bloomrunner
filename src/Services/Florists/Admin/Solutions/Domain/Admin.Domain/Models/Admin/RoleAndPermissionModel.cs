using System.ComponentModel.DataAnnotations;

namespace Admin.Domain.Models.Admin
{
    public class RoleAndPermissionModel
    {
        public int FloristId { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public int ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public int ModuleId { get; set; }
        public string ModuleName { get; set; } 
        public int ScreenId { get; set; }
        public string ScreenName { get; set; }
        public int ActionId { get; set; }
        public string ActionName { get; set; }
        public bool Allowed { get; set; }
    }
    public class GetRoleAndPermission
    {
        [Required]
        public int FloristId { get; set; }
        public int RoleId { get; set; }
    }
    public class AddRoleAndPermissionModel
    {
        public int FloristId { get; set; }
        public int RoleId { get; set; }
        public string CreatedBy { get; set; }
        public string RoleAndPermission { get; set; }
    }
    public class CloneRoleAndPermissionModel
    {
        public int FloristId { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string CreatedBy { get; set; }
    }
    public class SearchScreenActionModel
    {
        public int FloristId { get; set; }
        public int RoleId { get; set; }
        public int ModuleId { get; set; }
        public int ScreenId { get; set; }
    }
    public class ScreenActionModel
    {
        public int ActionId { get; set; }
        public string ActionName { get; set; }
        public bool Allowed { get; set; }
    }
}