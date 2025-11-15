using Microsoft.AspNetCore.Mvc;

namespace EFCoreInMemoryDemo.Web.Controllers
{
    public class DragAndDropController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
