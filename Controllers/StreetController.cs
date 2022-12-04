using Microsoft.AspNetCore.Mvc;

namespace MyProj.Controllers
{
    public class StreetController : Controller
    {
        public IActionResult Sindex()
        {
            return View();
        }
    }
}
