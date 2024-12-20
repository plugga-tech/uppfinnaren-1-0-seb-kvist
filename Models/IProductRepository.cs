using System;


namespace uppfinnaren_1_0_seb_kvist.Models;

public interface IProductRepository
{
    IEnumerable<Product> GetAllProducts(); 
    IEnumerable<Product> GetProductsByCategory(string category);
    Product? GetProductById(int id);
}