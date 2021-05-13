using System;

namespace Admin.Application.DTO.Request
{
    public class TaskDTO
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
    public class UpdateTaskStatusDTO
    {
        public int TaskId { get; set; }
        public int Status { get; set; }
        public string ModifiedBy { get; set; }
    }
}