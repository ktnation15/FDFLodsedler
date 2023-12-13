using FDFLodsedler.Data;
using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using FDFLodsedler.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FDFLodsedler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddRazorPages();
            builder.Services.AddDbContext<ApplicationDBContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("NewDatabase")));

            builder.Services.AddDbContext<LoginDBContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("Login")));
            builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<LoginDBContext>()

            .AddEntityFrameworkStores<LoginDBContext>()
            .AddDefaultTokenProviders();
            builder.Services.AddAuthorization();

            builder.Services.AddTransient<IBørn, BørnService>();
            builder.Services.AddTransient<IBørneGruppe, BørneGruppeService>();
            builder.Services.AddTransient<Ileder, LederService>();
            builder.Services.AddTransient<ILodseldler, LodseldlerService>();
            builder.Services.AddTransient<ISalg, SalgService>();
            builder.Services.AddTransient<IBestyrelse, BestyrelseService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}