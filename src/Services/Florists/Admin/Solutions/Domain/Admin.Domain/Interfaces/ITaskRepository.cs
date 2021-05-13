using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;

namespace Admin.Domain.Interfaces
{
    public interface ITaskRepository
    {
        Task<CommonResponse> AddTasks(TaskModel taskModel);
        Task<IEnumerable<TaskModelDerived>> GetTasksList(GetTaskListModel getTaskListModel);
        Task<IEnumerable<TaskModelDerived>> GetSearchTasksList(TaskSearchGrid taskSearchGrid);
        Task<CommonResponse> UpdateTaskStatus(UpdateTaskSatusModel updateTaskSatusModel);
        Task<CommonResponse> UpdateTask(UpdateTaskModel updateTaskModel);
        Task<CommonResponse> Update(UpdateModel updateModel);
        Task<int> DeleteTask(TaskDeleteModel taskDeleteModel);
    }
}