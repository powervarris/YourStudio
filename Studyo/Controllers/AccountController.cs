using Microsoft.AspNetCore.Mvc;
using Studyo.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Studyo.data;
using Studyo.Views.Inquiry;
using Studyo.Controllers;

namespace Studyo.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        
        private readonly ApplicationDbContext _context;
        
        private readonly UserManager<User> _userManager;
        
        private readonly SignInManager<User> _signInManager;
        public AccountController(ILogger<AccountController> logger, ApplicationDbContext context, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(User usermodel)
        {
            usermodel.dateCreated = DateTime.Now;
            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
            usermodel.PasswordHash = passwordHasher.HashPassword(usermodel, usermodel.password);
            await _userManager.CreateAsync(usermodel);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> loginUser(User usermodel)
        {
            var loginResult = await _signInManager.PasswordSignInAsync (usermodel.UserName, usermodel.password, false, false);
            if (loginResult.Succeeded)
            {
                return RedirectToAction("Index", "Home");
                
            }
            return RedirectToAction("Register");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
