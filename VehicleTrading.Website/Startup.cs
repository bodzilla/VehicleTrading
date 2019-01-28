﻿using System;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SmartBreadcrumbs;
using VehicleTrading.Core.Models;
using VehicleTrading.Persistence;

namespace VehicleTrading.Website
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            // Wire up dependency injections.
            services.WireUpDependencies();

            // Add context.
            services.AddDbContext<VehicleTradingContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // Add identity.
            services.AddIdentity<User, Role>()
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<VehicleTradingContext>()
                .AddDefaultTokenProviders();

            // Configure identity options.
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
            });

            // Configure site options.
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)

                // Prevents circular referencing loop when returning web api responses which include children objects.
                .AddJsonOptions(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddRouting(options => options.LowercaseUrls = true);
            services.UseBreadcrumbs(GetType().Assembly);

            // Route login path to custom route to prevent default identity login route from being used.
            services.PostConfigure<CookieAuthenticationOptions>(IdentityConstants.ApplicationScheme, options =>
            {
                options.LoginPath = "/Identity/Account/Signin";
                options.LogoutPath = "/Identity/Account/Signout";
            });

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            return serviceProvider;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");

                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
