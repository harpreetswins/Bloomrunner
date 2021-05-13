namespace Admin.Domain.Models.Admin
{
    public class HomeScreenModel
    {
        public string ScreenName { get; set; }
        public string ScreenCode { get; set; }
        public string ScreenDescription { get; set; }
        public string CreatedBy { get; set; }

    }
    public class HomeScreenDeleteModel
    {
        public int ScreenId { get; set; }
        public string DeletedBy { get; set; }

    }
    public class HomeScreenModelDerived : HomeScreenModel
    {
        public string ScreenId { get; set; }
        public string CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
        public string IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public string DeletedDate { get; set; }
    }
}