using BlotzTask.Models;
using BlotzTask.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlotzTask.Controllers
{
    [ApiController]
    [Authorize]
    [Route("/api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;
        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet("alltask")]
        public async Task<IActionResult> GetAllTask()
        {
            return Ok(await _taskService.GetTodoItems());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTaskByID(int id)
        {
            return Ok(await _taskService.GetTaskByID(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddTaskAsync([FromBody] AddTaskItemDTO addtaskItem)
        {
            return Ok(await _taskService.AddTask(addtaskItem));
        }
    }
}
