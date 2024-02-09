using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using YourStudio.Models;


namespace YourStudio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Submit(InquiryModel inquiry)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View("~/Views/Inquiry/Index.cshtml", inquiry);
        }
    }
}
