using Microsoft.AspNetCore.Mvc;

namespace EFCoreInMemoryDemo.Web.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
