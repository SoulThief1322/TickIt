using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TickIt.Controllers
{
    public class TasksController : Controller
    {
        private readonly ILogger<TasksController> _logger;

        public TasksController(ILogger<TasksController> logger)
        {
            _logger = logger;
            _logger.LogDebug("TasksController initialized.");
        }

        // GET: /Tasks or /Tasks/Index
        public IActionResult Index()
        {
            return View();
        }
    }
}