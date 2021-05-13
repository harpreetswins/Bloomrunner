using System.ComponentModel.DataAnnotations;

namespace Admin.Domain.Models.Admin
{
    public class GlobalCodeModel
    {
        public string CategoryName { get; set; }
        public string CodeName { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
    }
    public class GlobalCodeDeleteModel
    {
        public string CategoryName { get; set; }
        public int GlobalCodeId { get; set; }
        public string DeletedBy { get; set; }
    }
    public class GlobalCodeModelDerived : GlobalCodeModel
    {
        public int GlobalCodeId { get; set; }
        public int CategoryId { get; set; }
        public string CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
        public string IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public string DeletedDate { get; set; }
        public string IsActive { get; set; }
    }

    public class GlobelSearchModel
    {
        [Required]
        public string CategoryName { get; set; }
        public int GlobalCodeId { get; set; }
    }

    public class GlobalCodeCategoriesModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string AllowAddDelete { get; set; }
        public string AllowCodeNameEdit { get; set; }
        public string Description { get; set; }
        public string IsActive { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
        public string IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public string DeletedDate { get; set; }
    }
    public class GlobelcodeSearchListDerivedModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int GlobalCodeId { get; set; }
        public string CodeName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int TotalRows { get; set; }
    }
    public class GlobelcodeSearchListModel
    {
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public string SearchValue { get; set; }
        public string SortColumn { get; set; }
        public string SortOrder { get; set; }
    }
    public class GlobelcodeUpdateModel
    {
      public int GlobalCodeId { get; set; }   
      public string CodeName { get; set; }         
      public string Description { get; set; }
      public string ModifiedBy { get; set; }   
    }

    public class GlobelcodeUpdateStatusModel
    {
        public int GlobalCodeId { get; set; }
        public bool IsActive { get; set; }
        public string ModifiedBy { get; set; }
    }
}