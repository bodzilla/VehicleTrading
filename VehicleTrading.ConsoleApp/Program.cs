using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;
using VehicleTrading.ConsoleApp.Models;
using VehicleTrading.Core.Contracts.Repositories;
using VehicleTrading.Core.Contracts.Services;
using VehicleTrading.Core.Contracts.Uow;
using VehicleTrading.Core.Enums;
using VehicleTrading.Core.Models;
using VehicleTrading.Core.Services;
using VehicleTrading.Persistence;
using VehicleTrading.Persistence.Repositories;
using VehicleTrading.Persistence.Uow;

namespace VehicleTrading.ConsoleApp
{
    public sealed class Program
    {

        private static async Task Main()
        {
            var serviceProvider = GetServiceProvider();
            var carMakeService = serviceProvider.GetService<ICarMakeService>();
            var carModelService = serviceProvider.GetService<ICarModelService>();

            const string url = "https://raw.githubusercontent.com/matthlavacka/car-list/master/car-list.json";
            var vehicles = GetVehicles(url);

            foreach (var vehicle in vehicles)
            {
                CarMake carMake;
                bool carMakeExists = await carMakeService.NameExistsAsync(vehicle.Brand);

                if (!carMakeExists)
                {
                    carMake = new CarMake { Name = vehicle.Brand };
                    await carMakeService.CreateAsync(carMake);
                    Console.WriteLine($"Car Make {carMake.Name} created.");
                }
                else
                {
                    carMake = await carMakeService.GetAsync(vehicle.Brand);
                }

                if (carMake == null) throw new ArgumentException("CarMake object not initialized.");

                foreach (var model in vehicle.Models)
                {
                    bool carModelExists = await carModelService.NameExistsAsync(model);
                    if (carModelExists) continue;
                    var carModel = new CarModel
                    {
                        Name = model,
                        VehicleType = VehicleType.Car,
                        CarMakeId = carMake.Id
                    };
                    await carModelService.CreateAsync(carModel);
                    Console.WriteLine($"Car Model {carModel.Name} created.");
                }
            }
        }

        private static IEnumerable<VehiclesResponse> GetVehicles(string url)
        {
            var response = ExecuteWebRequest(url);
            var json = JToken.Parse(response);
            IEnumerable<VehiclesResponse> vehicles = json.Select(item => item.ToObject<VehiclesResponse>()).ToList();
            return vehicles;
        }

        private static string ExecuteWebRequest(string url)
        {
            string data;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Timeout = 5000;
            request.ReadWriteTimeout = 5000;
            request.Method = "GET";

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream ?? throw new InvalidOperationException("Stream returns null.")))
                    {
                        data = reader.ReadToEnd();
                    }
                }
            }
            return data;
        }

        private static ServiceProvider GetServiceProvider()
        {
            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            var config = configBuilder.Build();

            var serviceProvider = new ServiceCollection()
                .AddScoped<DbContext, VehicleTradingContext>()
                .AddScoped<VehicleTradingContext>()
                .AddScoped<ICarMakeRepository, CarMakeRepository>()
                .AddScoped<ICarModelRepository, CarModelRepository>()
                .AddScoped<ICarMakeUow, CarMakeUow>()
                .AddScoped<ICarModelUow, CarModelUow>()
                .AddScoped<ICarMakeService, CarMakeService>()
                .AddScoped<ICarModelService, CarModelService>()
                .AddDbContext<VehicleTradingContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            var builder = serviceProvider.BuildServiceProvider();
            return builder;
        }
    }
}
