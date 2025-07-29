using Microsoft.AspNetCore.Mvc;
namespace TaskApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private static List<Task> tasks = new List<Task>
        {
            new Task(1, "Task 1", "Description for Task 1"),
            new Task(2, "Task 2", "Description for Task 2")
        };
        public static int NextId = 3;

        [HttpGet]
        public ActionResult<IEnumerable<Task>> GetAll()
        {
            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public ActionResult<Task> GetTask(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }

        [HttpPost]
        public ActionResult<Task> CreateTask(Task task)
        {
            task.Id = NextId++;
            tasks.Add(task);
            return CreatedAtAction(nameof(GetTask), new { id = task.Id }, task);

        }

        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id, Task updatedTask)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
            {
                return NotFound();
            }
            task.Title = updatedTask.Title;
            task.Description = updatedTask.Description;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
            {
                return NotFound();
            }
            tasks.Remove(task);
            return NoContent();
        }
    }
}
