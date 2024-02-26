using Microsoft.AspNetCore.Mvc;
using YourStudio.Models;

public class BookingController : Controller
{
    public ActionResult Index()
    {
        return View();
    }

	public IActionResult BList()
	{
		return View();
	}

	public IActionResult Booking()
	{
		return View();
	}
}
