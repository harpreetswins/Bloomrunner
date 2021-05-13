using System;
using System.ComponentModel.DataAnnotations;

namespace Admin.Domain.Models.Admin
{
    public class TagModel
    {
        [Required]
        public int TagCollectionId { get; set; }
        [Required]
        public int FloristId { get; set; }
        [Required]
        public string TagName { get; set; }
        [Required]
        public string CreatedBy { get; set; }
    }
    public class TagDerivedModel : TagModel                                // Individually for System Tags , Not for Products/Florists/Staffs 
    {
        public int TagId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DeletedDate { get; set; }
    }
    public class TagDeleteModel
    {
        [Required]
        public int TagCollectionId { get; set; }
        [Required]
        public int FloristId { get; set; }
        [Required]
        public int TagId { get; set; }
        [Required]
        public string DeletedBy { get; set; }
    }
    public class TagUpdateModel
    {
        [Required]
        public int TagCollectionId { get; set; }
        [Required]
        public int FloristId { get; set; }
        [Required]
        public int TagId { get; set; }
        [Required]
        public string TagName { get; set; }
        [Required]
        public string ModifiedBy { get; set; }
    }
    public class TagUpdateStatusModel
    {
        [Required]
        public int TagCollectionId { get; set; }
        [Required]
        public int FloristId { get; set; }
        [Required]
        public int TagId { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public string ModifiedBy { get; set; }
    }
}