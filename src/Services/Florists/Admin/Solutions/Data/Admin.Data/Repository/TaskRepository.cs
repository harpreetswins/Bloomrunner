using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Interfaces;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;
using Microsoft.Extensions.Configuration;

namespace Admin.Data.GenericRepository
{
    public class TaskRepository : GenericRepository, ITaskRepository
    {
        public TaskRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<CommonResponse> AddTasks(TaskModel taskModel)
        {
            return await ExecuteAll<CommonResponse>("Glo.AddTasks", taskModel);
        }
        public async Task<IEnumerable<TaskModelDerived>> GetTasksList(GetTaskListModel getTaskListModel)
        {
            return await Query<TaskModelDerived>("Glo.GetTasksList", getTaskListModel);
        }
        public async Task<IEnumerable<TaskModelDerived>> GetSearchTasksList(TaskSearchGrid taskSearchGrid)
        {
            return await Query<TaskModelDerived>("Glo.GetTasksListSearching", taskSearchGrid);
        }
        public async Task<int> DeleteTask(TaskDeleteModel taskDeleteModel)
        {
            return await Command<TaskDeleteModel>("Glo.DeleteTask", taskDeleteModel);
        }
        public async Task<CommonResponse> UpdateTaskStatus(UpdateTaskSatusModel updateTaskSatusModel)
        {
            return await ExecuteAll<CommonResponse>("Glo.UpdateTaskStatus", updateTaskSatusModel);
        }
        public async Task<CommonResponse> UpdateTask(UpdateTaskModel updateTaskModel)
        {
            return await ExecuteAll<CommonResponse>("Glo.UpdateTask", updateTaskModel);
        }
        public async Task<CommonResponse> Update(UpdateModel updateModel)
        {
            return await ExecuteAll<CommonResponse>("Glo.UpdateCompleteTask", updateModel);
        }
    }
}