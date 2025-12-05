using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TickIt.Data;

namespace TickIt.Controllers
{
    public class TasksController : Controller
    {
        private readonly ILogger<TasksController> _logger;
        private readonly ApplicationDbContext _dbContext;

        public TasksController(ILogger<TasksController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
            _logger.LogDebug("TasksController initialized.");
        }

        public async Task<IActionResult> Tasks()
        {
            var tasks = await _dbContext.TaskItems.ToListAsync();
            return View(tasks);
        }
    }
}