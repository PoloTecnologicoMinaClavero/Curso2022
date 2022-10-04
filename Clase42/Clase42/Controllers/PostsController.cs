using Microsoft.AspNetCore.Mvc;

namespace Clase42.Controllers
{
    public class PostsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
