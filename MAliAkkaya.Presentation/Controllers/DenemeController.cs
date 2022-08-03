using Microsoft.AspNetCore.Mvc;

namespace MAliAkkaya.Presentation.Controllers
{
    public class DenemeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
