using Microsoft.AspNetCore.Mvc;
using crud_opration.Models;
using crud_opration.Repository;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace crud_opration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRepository _taskRepository;
        public TaskController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Task>>> GetTasks()
        {
            var tasks = await _taskRepository.GetTasks();
            return Ok(tasks);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Task>> GetTaskById(int id)
        {
            var task = await _taskRepository.GetTaskById(id);
            if (task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }
    }
}