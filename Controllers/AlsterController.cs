using System;
using Microsoft.AspNetCore.Mvc;
using uppfinnaren_1_0_seb_kvist.Models; 

namespace uppfinnaren_1_0_seb_kvist.Controllers
{
    public class AlsterController : Controller
    {
        private readonly IAlsterRepository _alsterRepository; 


        //DI - hämtar in alster från repository
        public AlsterController(IAlsterRepository alsterRepository) 
        {
            _alsterRepository = alsterRepository;
        }

        public IActionResult Index() //Visar alla alster
        {
            var alster = _alsterRepository.AllaAlster();
            return View("AllaAlster", alster);
        }

        // Detaljer visar info beroende alster ID
        public IActionResult Detaljer(int id)
        {
            var alster = _alsterRepository.HittaAlsterMedId(id); 
            if (alster == null)
            {
                return NotFound(); 
            }
            return View(alster); 
        }
    }
}