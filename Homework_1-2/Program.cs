using Homework_1_2.Services.FileName;
using Homework_1_2.Services.Hash;
using Homework_1_2.Services.KDF;
using Homework_1_2.Services.OTP;

namespace Homework_1_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddSingleton<IHashService, ShaHashService>();
            builder.Services.AddSingleton<IKdfService, Pbkdf1Service>();

            // builder.Services.AddSingleton<IOtpService, Otp6Service>();
            builder.Services.AddSingleton<IOtpService, Otp4Service>();

            builder.Services.AddTransient<IFileNameService, FileNameService>();

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

            app.Run();
        }
    }
}
