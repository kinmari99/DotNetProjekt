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

            // Dodanie us�ug do kontenera DI
            builder.Services.AddControllersWithViews();

            // Konfiguracja bazy danych
            builder.Services.AddDbContext<HotelsDBContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

            // Konfiguracja uwierzytelniania za pomoc� ciasteczek
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.LoginPath = "/Logowanie/Index"; // �cie�ka do strony logowania
                options.AccessDeniedPath = "/Home/Error"; // �cie�ka w przypadku braku dost�pu
            });

            // Konfiguracja autoryzacji
            builder.Services.AddAuthorization(options =>
            {
                // Przyk�ad polityki tylko dla administrator�w
                options.AddPolicy("AdminPolicy", policy => policy.RequireRole("Admin"));
            });

            var app = builder.Build();

            // Konfiguracja potoku ��da� HTTP
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

            // Mapowanie domy�lnej trasy MVC
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            // Opcjonalne: Mapowanie kontroler�w WebAPI
            app.MapControllers();

            app.Run();
        }
    }
}