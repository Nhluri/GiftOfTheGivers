using Microsoft.AspNetCore.Mvc;

namespace GiftOfTheGivers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // If user is already logged in, redirect to their dashboard
            if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole("Admin"))
                    return RedirectToAction("Dashboard", "Admin");
                else if (User.IsInRole("Volunteer"))
                    return RedirectToAction("Dashboard", "Volunteer");
                else
                    return RedirectToAction("Dashboard", "User");
            }

            // Show public home page for non-authenticated users
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}