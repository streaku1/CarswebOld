using Microsoft.AspNetCore.Mvc;

namespace Carsweb.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
