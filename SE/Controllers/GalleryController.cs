using Microsoft.AspNetCore.Mvc;

namespace SE.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
