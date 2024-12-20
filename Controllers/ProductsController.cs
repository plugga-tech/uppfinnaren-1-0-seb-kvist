using System;
using Microsoft.AspNetCore.Mvc;
using uppfinnaren_1_0_seb_kvist.Models;

namespace uppfinnaren_1_0_seb_kvist.Controllers
{

    //Controller som kommer hantera allt relaterat till produkter
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;

        // Konstruktor
        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // Viewaction för att visa alla kategorier på sidan med bilder från alster
        public IActionResult Index()
        {
        var categories = _productRepository.GetAllProducts()
            .Select(p => p.ProductCategory)
            .Distinct()
            .ToList();

        var categoryData = new List<object>(); // Lista för att spara bild och kategori

        foreach (var category in categories)
            {
            string imagePath = string.Empty;
            
            if (category == "Bokhylla")
            {imagePath = "/bilder/Bokhylla/trabokhylla3.jpg";}

            else if (category == "Bord")
            {imagePath = "/bilder/Bord/trabord2.jpg";}

            else if (category == "Träram")
            {imagePath = "/bilder/Tavla/traram2.jpg";}

            else if (category == "Träskor")
            {imagePath = "/bilder/Traskor/trasko2.jpg";}

            // Lägger till bild och kategori i listan
            categoryData.Add(new
            {
                Category = category,
                Image = imagePath
            });
            }

            return View(categoryData);
        }


        //Viewaction som visa detaljer beorende på vilket produkt-id man klickar på
        public IActionResult Details(int id)
        {
            var product = _productRepository.GetProductById(id);
            return View(product);
        }

        // Viewaction för att visa produkter för en vald kategori
        public IActionResult ByCategory(string category)
        {
            var products = _productRepository.GetProductsByCategory(category);
            ViewData["CategoryName"] = category;
            return View(products);
        }
    }
}
