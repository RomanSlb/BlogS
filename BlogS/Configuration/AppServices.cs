using BlogS.BusinessManagers;
using BlogS.BusinessManagers.Interfaces;
using BlogS.Data;
using BlogS.Data.Models;
using BlogS.Service.Interfaces;
using BlogS.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.FileProviders;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using BlogS.Authorization;

namespace BlogS.Configuration
{
    public static class AppServices
    {
        public static void AddDefaultServices(this IServiceCollection servicesCollection, IConfiguration configuration)
        {

            servicesCollection.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(
                        configuration.GetConnectionString("DefaultConnection")));
            servicesCollection.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            servicesCollection.AddControllersWithViews().AddRazorRuntimeCompilation();
            servicesCollection.AddRazorPages();

            servicesCollection.AddSingleton<IFileProvider>(new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")));
        }
        public static void AddCustomServices(this IServiceCollection servicesCollection)
        {
            servicesCollection.AddScoped<IPostBusinessManager, PostBusinessManager>();
            servicesCollection.AddScoped<IAdminBusinessManager, AdminBusinessManager>();
            servicesCollection.AddScoped<IHomeBusinessManager, HomeBusinessManager>();


            servicesCollection.AddScoped<IPostService, PostService>();
            servicesCollection.AddScoped<IUserService, UserService>();

        }
        public static void AddCustomAuthorization(this IServiceCollection servicesCollection)
        {
            servicesCollection.AddTransient<IAuthorizationHandler, PostAuthorizationHandler>();
        }

    }
}
