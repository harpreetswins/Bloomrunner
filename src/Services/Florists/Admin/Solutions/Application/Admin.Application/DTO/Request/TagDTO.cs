namespace Admin.Application.DTO.Request
{
    public class TagDTO
    {
        public int TagCollectionId { get; set; }
        public int FloristId { get; set; }
        public string TagName { get; set; }
        public string CreatedBy { get; set; }
    }
    public class TagUpdateDTO
    {
        public int TagCollectionId { get; set; }
        public int FloristId { get; set; }
        public int TagId { get; set; }
        public string TagName { get; set; }
        public string ModifiedBy { get; set; }
    }
}