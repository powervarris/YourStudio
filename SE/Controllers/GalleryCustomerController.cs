using Microsoft.AspNetCore.Mvc;

namespace SE.Controllers
{
    public class GalleryCustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
