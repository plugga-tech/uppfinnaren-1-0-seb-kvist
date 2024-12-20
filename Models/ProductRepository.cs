using System;
using uppfinnaren_1_0_seb_kvist.Data;
namespace uppfinnaren_1_0_seb_kvist.Models;


public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        //Konstruktor för Databas
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        //Hämtar produkter från databasen
        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToList(); 
        }

        //Hämtar produkter från databasen efter kategori
        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return _context.Products
                            .Where(p => p.ProductCategory == category) //Sorterar in produkter efter kategorin --> in i en lista
                            .ToList();
        }

        // Hämtar produkt baserat på ID't
        public Product? GetProductById(int id)
            {
                return _context.Products.FirstOrDefault(p => p.ProductId == id);
            }
    }
