using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Application.Interfaces;
using Admin.Domain.Interfaces;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;

namespace Admin.Application.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskrepository;
        public TaskService(ITaskRepository taskRepository)
        {
            _taskrepository = taskRepository;
        }
        public async Task<IEnumerable<TaskModelDerived>> GetTasksList(GetTaskListModel getTaskListModel)
        {
            return await _taskrepository.GetTasksList(getTaskListModel);
        }
        public async Task<IEnumerable<TaskModelDerived>> GetSearchTasksList(TaskSearchGrid taskSearchGrid)
        {
            return await _taskrepository.GetSearchTasksList(taskSearchGrid);
        }
        public async Task<CommonResponse> AddTasks(TaskModel taskModel)
        {
            return await _taskrepository.AddTasks(taskModel);
        }
        public async Task<int> DeleteTask(TaskDeleteModel taskDeleteModel)
        {
            return await _taskrepository.DeleteTask(taskDeleteModel);
        }
        /// <summary>
        /// This method will used to Update the Status of the task
        /// </summary>
        public async Task<CommonResponse> UpdateTaskStatus(UpdateTaskSatusModel updateTaskSatusModel)
        {
            return await _taskrepository.UpdateTaskStatus(updateTaskSatusModel);
        }
        /// <summary>
        /// This method will used to Update the IsActive Status of the task
        /// </summary>
        public async Task<CommonResponse> UpdateTask(UpdateTaskModel updateTaskModel)
        {
            return await _taskrepository.UpdateTask(updateTaskModel);
        }
        /// <summary>
        /// This method will used to Update the Complete Details of the task
        /// </summary>
        public async Task<CommonResponse> Update(UpdateModel updateModel)
        {
            return await _taskrepository.Update(updateModel);
        }
    }
}