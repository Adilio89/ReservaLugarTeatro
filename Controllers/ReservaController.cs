using Microsoft.AspNetCore.Mvc;

namespace ReservaLugarTeatro.Controllers
{
    public class ReservaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
