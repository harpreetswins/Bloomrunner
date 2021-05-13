namespace Admin.Domain.Models.Admin
{
    public class RolesModel
    {
        public int FloristId { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string AssignedTo { get; set; }
    }
    public class AddRolesModel
    {
        public int FloristId { get; set; }
        public string RoleName { get; set; }
        public string CreatedBy { get; set; }
    }
}