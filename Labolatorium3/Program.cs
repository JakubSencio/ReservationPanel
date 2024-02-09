using Labolatorium3.Models;
using System.Xml.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Data;


namespace Labolatorium3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
                        var connectionString = builder.Configuration.GetConnectionString("AppDbContextConnection") ?? throw new InvalidOperationException("Connection string 'AppDbContextConnection' not found.");

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<IDateTimeProvider, CurrentDateTimeProvider>();

            builder.Services.AddDbContext<Data.AppDbContext>();
            builder.Services.AddDefaultIdentity<IdentityUser>()       // dodać
    .AddRoles<IdentityRole>()                             //
    .AddEntityFrameworkStores<Data.AppDbContext>();

            builder.Services.AddTransient<IReservationService, EFReservationService>();
            builder.Services.AddMemoryCache();                        // dodać
            builder.Services.AddSession();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // dThe default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();                                 // dodać
            app.UseAuthorization();                                  // dodać
            app.UseSession();                                        // dodać 
            app.MapRazorPages();                                     // dodać

            app.MapControllerRoute(
                name: "default",    
                pattern: "{controller=Reservation}/{action=Index}/{id?}");

            app.Run();

        }
    }
}