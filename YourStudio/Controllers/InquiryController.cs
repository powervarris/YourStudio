using Microsoft.AspNetCore.Mvc;
using YourStudio.Models;

public class InquiryController : Controller
{
    // Action to display the inquiry form
    public ActionResult Index()
    {
        return View();
    }

    // Action to handle form submission
    [HttpPost]
    public ActionResult Submit(InquiryModel inquiry)
    {
        return RedirectToAction("Index");
    }

    // Action for the thank you page
    public ActionResult ThankYou()
    {
        return View();
    }
}
