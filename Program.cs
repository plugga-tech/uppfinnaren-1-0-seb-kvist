using uppfinnaren_1_0_seb_kvist.Data;
using uppfinnaren_1_0_seb_kvist.Models;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IProductRepository, ProductRepository>(); 

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("InMemoryDb"));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    if (!context.Products.Any())
    {
        context.Products.AddRange(new[]
        {
            new Product { ProductName = "Träsko 1", ProductCategory = "Träskor", ImagePath = "/bilder/Traskor/trasko.jpg" },
            new Product { ProductName = "Träsko 2", ProductCategory = "Träskor", ImagePath = "/bilder/Traskor/trasko2.jpg" },
            new Product { ProductName = "Träsko 3", ProductCategory = "Träskor", ImagePath = "/bilder/Traskor/trasko3.jpg" },
            new Product { ProductName = "Träsko 4", ProductCategory = "Träskor", ImagePath = "/bilder/Traskor/trasko4.jpg" },
            new Product { ProductName = "Träbord 1", ProductCategory = "Bord", ImagePath = "/bilder/Bord/trabord.jpg" },
            new Product { ProductName = "Träbord 2", ProductCategory = "Bord", ImagePath = "/bilder/Bord/trabord2.jpg" },
            new Product { ProductName = "Träbord 3", ProductCategory = "Bord", ImagePath = "/bilder/Bord/trabord3.jpg" },
            new Product { ProductName = "Träbord 4", ProductCategory = "Bord", ImagePath = "/bilder/Bord/trabord4.jpg" },
            new Product { ProductName = "Träram 1", ProductCategory = "Träram", ImagePath = "/bilder/Tavla/traram.jpg" },
            new Product { ProductName = "Träram 2", ProductCategory = "Träram", ImagePath = "/bilder/Tavla/traram2.jpg" },
            new Product { ProductName = "Träram 3", ProductCategory = "Träram", ImagePath = "/bilder/Tavla/traram3.jpg" },
            new Product { ProductName = "Träram 4", ProductCategory = "Träram", ImagePath = "/bilder/Tavla/traram4.jpg" },
            new Product { ProductName = "Träbokhylla 1", ProductCategory = "Bokhylla", ImagePath = "/bilder/Bokhylla/trabokhylla.jpg" },
            new Product { ProductName = "Träbokhylla 2", ProductCategory = "Bokhylla", ImagePath = "/bilder/Bokhylla/trabokhylla2.jpg" },
            new Product { ProductName = "Träbokhylla 3", ProductCategory = "Bokhylla", ImagePath = "/bilder/Bokhylla/trabokhylla3.jpg" },
            new Product { ProductName = "Träbokhylla 4", ProductCategory = "Bokhylla", ImagePath = "/bilder/Bokhylla/trabokhylla4.jpg" }
        });

        context.SaveChanges();
    }
}
app.Run();