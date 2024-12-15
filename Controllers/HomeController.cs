using Microsoft.AspNetCore.Mvc;

namespace uppfinnaren_1_0_seb_kvist.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() //// Skickar användaren till en startsida
        {
            return View();  
        }


        public IActionResult Privacy()
        {
            return View();  // Privacy-vyn - visa information om sekretess och användarvillkor.
        }
    }
}