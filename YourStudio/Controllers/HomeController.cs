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
        public IActionResult Inquiry()
        {
            return View(new InquiryModel());
        }
        public IActionResult Inquirylist(InquiryModel inquiry)
        {
            if (ModelState.IsValid)
            {
                TempData["SubmittedInquiry"] = inquiry;
                return RedirectToAction("InquiryDetails");
            }
            return View("~/Views/Home/Inquirylist.cshtml", inquiry);
        }


        [HttpPost]
        public ActionResult Submit(InquiryModel inquiry)
        {
            if (ModelState.IsValid)
            {
				TempData["SubmittedInquiry"] = inquiry;

				return RedirectToAction("InquiryDetails");
			}
            return View("~/Views/Home/Inquirylist.cshtml", inquiry);
        }
		public ActionResult InquiryDetails()
		{
			var submittedInquiry = TempData["SubmittedInquiry"] as InquiryModel;

			if (submittedInquiry != null)
			{
				return View(submittedInquiry);
			}

			return RedirectToAction("Error");
		}
	}
}
