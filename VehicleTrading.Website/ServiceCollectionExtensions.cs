using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VehicleTrading.Core.Contracts.Repositories;
using VehicleTrading.Core.Contracts.Services;
using VehicleTrading.Core.Contracts.Uow;
using VehicleTrading.Core.Services;
using VehicleTrading.Persistence;
using VehicleTrading.Persistence.Repositories;
using VehicleTrading.Persistence.Uow;

namespace VehicleTrading.Website
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Contains configurations for wiring up all dependency injections.
        /// </summary>
        public static void WireUpDependencies(this IServiceCollection services)
        {
            // Database context.
            services.AddScoped<DbContext, VehicleTradingContext>();
            services.AddScoped<VehicleTradingContext>();

            // Repositories.
            services.AddScoped<ISettingsRepository, SettingsRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ISellerRepository, SellerRepository>();
            services.AddScoped<ICarMakeRepository, CarMakeRepository>();
            services.AddScoped<ICarModelRepository, CarModelRepository>();
            services.AddScoped<IAdRepository, AdRepository>();
            services.AddScoped<IAdVersionRepository, AdVersionRepository>();
            services.AddScoped<IImageRepository, ImageRepository>();

            // UOW.
            services.AddScoped<ISettingsUow, SettingsUow>();
            services.AddScoped<IUserUow, UserUow>();
            services.AddScoped<ISellerUow, SellerUow>();
            services.AddScoped<ICarMakeUow, CarMakeUow>();
            services.AddScoped<ICarModelUow, CarModelUow>();
            services.AddScoped<IAdUow, AdUow>();
            services.AddScoped<IAdVersionUow, AdVersionUow>();
            services.AddScoped<IImageUow, ImageUow>();

            // Services.
            services.AddScoped<ISettingsService, SettingsService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ISellerService, SellerService>();
            services.AddScoped<ICarMakeService, CarMakeService>();
            services.AddScoped<ICarModelService, CarModelService>();
            services.AddScoped<IAdService, AdService>();
            services.AddScoped<IAdVersionService, AdVersionService>();
            services.AddScoped<IImageService, ImageService>();
        }
    }
}
