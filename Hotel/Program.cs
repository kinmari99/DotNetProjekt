using Hotel.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

namespace Hotel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Dodanie us³ug do kontenera DI
            builder.Services.AddControllersWithViews();

            // Konfiguracja bazy danych
            builder.Services.AddDbContext<HotelsDBContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

            // Konfiguracja uwierzytelniania za pomoc¹ ciasteczek
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.LoginPath = "/Logowanie/Index"; // Œcie¿ka do strony logowania
                options.AccessDeniedPath = "/Home/Error"; // Œcie¿ka w przypadku braku dostêpu
            });

            // Konfiguracja autoryzacji
            builder.Services.AddAuthorization(options =>
            {
                // Przyk³ad polityki tylko dla administratorów
                options.AddPolicy("AdminPolicy", policy => policy.RequireRole("Admin"));
            });

            var app = builder.Build();

            // Konfiguracja potoku ¿¹dañ HTTP
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // Ustawienie HSTS dla produkcji
                app.UseHsts();
            }

            // Przekierowanie na HTTPS
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            // Middleware routing
            app.UseRouting();

            // Middleware uwierzytelniania i autoryzacji
            app.UseAuthentication();
            app.UseAuthorization();

            // Mapowanie domyœlnej trasy MVC
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            // Opcjonalne: Mapowanie kontrolerów WebAPI
            app.MapControllers();

            app.Run();
        }
    }
}