using System;
using System.Net;
using System.Threading.Tasks;
using Admin.API.Infrastructure.CustomMapper;
using Admin.Application.DTO.Request;
using Admin.Application.Interfaces;
using Admin.Domain.Models.Admin;
using Microsoft.AspNetCore.Mvc;

namespace Admin.API.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("1.1")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;
        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }
        [HttpGet("GetStaffTaskList")]
        public async Task<ActionResult> GetGetStaffTaskList([FromQuery] GetTaskListModel getTaskListModel)
        {
            var list = await _taskService.GetTasksList(getTaskListModel);
            return Ok(list);
        }
        [HttpGet()]
        public async Task<ActionResult> Get([FromQuery] TaskSearchGrid taskSearchGrid)
        {
            var list = await _taskService.GetSearchTasksList(taskSearchGrid);
            return Ok(list);
        }
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Post([FromBody] TaskDTO model)
        {
            TaskModel task = new DTOMapper<TaskDTO, TaskModel>().Serialize(model);
            var taskid = await _taskService.AddTasks(task);
            return Ok(taskid);
        }
        [HttpPut()]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Put([FromBody] UpdateModel updateModel)
        {
            var update = await _taskService.Update(updateModel);
            return Ok(update);
        }
        [HttpPatch]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> Put([FromBody] UpdateTaskStatusDTO updateTaskStatusDTO)
        {
            UpdateTaskSatusModel updatestatus = new DTOMapper<UpdateTaskStatusDTO, UpdateTaskSatusModel>().Serialize(updateTaskStatusDTO);
            var statusid = await _taskService.UpdateTaskStatus(updatestatus);
            return Ok(statusid);
        }
        [HttpPut("UpdateTask")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Put([FromBody] UpdateTaskModel updateTaskModel)
        {
            var updatetask = await _taskService.UpdateTask(updateTaskModel);
            return Ok(updatetask);
        }
        [HttpDelete]
        public async Task<ActionResult> Delete([FromQuery] TaskDeleteModel taskDeleteModel)
        {
            var TaskDelete = await _taskService.DeleteTask(taskDeleteModel);
            return Ok(TaskDelete);
        }
    }
}