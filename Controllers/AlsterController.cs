using System;
using Microsoft.AspNetCore.Mvc;
using uppfinnaren_1_0_seb_kvist.Models; //Importerar in models

namespace uppfinnaren_1_0_seb_kvist.Controllers
{
    public class AlsterController : Controller
    {
        private readonly IAlsterRepository _alsterRepository; //Sätter en variabel som lagrar vårt repository

        public AlsterController(IAlsterRepository alsterRepository)  //Konstruktor. Skapar en instans av controller och ger den vårt repository
        {
            _alsterRepository = alsterRepository;
        }

        public IActionResult Index() //Så man kan se alla alster
        {
            var allaAlster = _alsterRepository.AllaAlster; //HÄmtar in alla olika alster
            return View(allaAlster); //Skickar till View delen för visning senare
        }
        public IActionResult Detaljer(int id) //Specifika utpekning av alster ID
            {
            var alster = _alsterRepository.HämtaAlsterMedId(id);

            if (alster == null)
            {
                return NotFound();
            }

            return View(alster);
        }
    }
}