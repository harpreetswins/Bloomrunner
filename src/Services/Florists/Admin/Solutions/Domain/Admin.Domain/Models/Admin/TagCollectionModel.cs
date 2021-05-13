namespace Admin.Domain.Models.Admin
{
    public class TagCollectionModel
    {
        public string TagName { get; set; }
    }

    public class TagGridListModel
    {
        public int FloristId { get; set; }
        public int TagCollectionId { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public string SearchValue { get; set; }
        public string SortColumn { get; set; }
        public string SortOrder { get; set; }
    }
    public class TagGridListDrivedModel
    {
        public int TagCollectionId { get; set; }
        public int FloristId { get; set; }
        public int TagId { get; set; }
        public string TagName { get; set; }
        public int UsedCount { get; set; }
        public bool IsActive { get; set; }
        public string TotalRows { get; set; }
    }

    public class TagCollectionGridModel
    {
        public int FloristId { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public string SearchValue { get; set; }
        public string SortColumn { get; set; }
        public string SortOrder { get; set; }
    }
    public class TagCollectionGridResponse
    {
        public int TagCollectionId { get; set; }
        public string TagCollectionName { get; set; }
        public int TagsCount { get; set; }
    }
}