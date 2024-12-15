using System;
using Microsoft.AspNetCore.Mvc;
using uppfinnaren_1_0_seb_kvist.Models;

namespace uppfinnaren_1_0_seb_kvist.Controllers
{
    public class AboutMeController : Controller
    {
        public IActionResult Index() //FÖr att kunna se AboutMeModel.
        {
            var model = new AboutMeModel
            {
                Namn = "Toshi Nilsson", Email = "ToshiIVerket@Nothingburger.com", Telefonnummer = "072-2275946"
            };

            return View("AboutMe", model);
        }
    }
}