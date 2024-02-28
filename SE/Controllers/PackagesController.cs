using Microsoft.AspNetCore.Mvc;

namespace SE.Controllers
{
    public class PackagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
