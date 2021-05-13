using System;
using System.ComponentModel.DataAnnotations;

namespace Admin.Domain.Models.Admin
{
    public class TaskModel
    {
        public int FloristId { get; set; }
        public int AssignedBy { get; set; }
        public int AssignedTo { get; set; }
        public int Status { get; set; }
        public DateTime DueBy { get; set; }
        public string Task { get; set; }
        public string TaskDescription { get; set; }
        public string CreatedBy { get; set; }
    }
    public class GetTaskListModel
    {
        [Required]
        public int FloristId { get; set; }
        public int StaffId { get; set; }
    }
    public class TaskModelDerived : TaskModel
    {
        public int TaskId { get; set; }
        public bool IsActive { get; set; }
        public string StatusName { get; set; }
        public string AssignedByName { get; set; }
        public string AssignedToName { get; set; }
        public string TotalRows { get; set; }
    }
    public class TaskSearchGrid
    {
        [Required]
        public int FloristId { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public string SearchValue { get; set; }
        public string SortColumn { get; set; }
        public string SortOrder { get; set; }
    }
    public class TaskDeleteModel
    {
        public int TaskId { get; set; }
        public int FloristId { get; set; }
        public string DeletedBy { get; set; }
    }
    public class UpdateTaskSatusModel
    {
        public int TaskId { get; set; }
        public int Status { get; set; }
        public string ModifiedBy { get; set; }
    }
    public class UpdateTaskModel
    {
        public int TaskId { get; set; }
        public bool IsActive { get; set; }
        public string ModifiedBy { get; set; }
    }
    public class UpdateModel : UpdateTaskSatusModel
    {
        public int FloristId { get; set; }
        public int AssignedBy { get; set; }
        public int AssignedTo { get; set; }
        public DateTime DueBy { get; set; }
        public string Task { get; set; }
        public string TaskDescription { get; set; }
    }
}