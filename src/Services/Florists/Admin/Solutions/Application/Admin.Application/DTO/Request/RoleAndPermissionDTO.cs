using System.Collections.Generic;

namespace Admin.Application.DTO.Request
{
    public class RoleAndPermissionDTO
    {
        public int FloristId { get; set; }
        public int RoleId { get; set; }
        public string CreatedBy { get; set; }
        public List<RoleAndPermission> RoleAndPermission { get; set; }
    }
    public class RoleAndPermission
    {                
        public int ApplicationId { get; set; }
        public int ModuleId { get; set; }
        public int ScreenId { get; set; }
        public int ActionId { get; set; }
        public bool Allowed { get; set; }        

    }
    public class CloneRoleAndPermission
    {
        public int FloristId { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string CreatedBy { get; set; }
    }
}