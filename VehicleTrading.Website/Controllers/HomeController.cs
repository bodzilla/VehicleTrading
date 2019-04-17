using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SmartBreadcrumbs;
using VehicleTrading.Core.ViewModels;

namespace VehicleTrading.Website.Controllers
{
    public class HomeController : Controller
    {
        [DefaultBreadcrumb("Dashboard")]
        public IActionResult Index() => View();

        public IActionResult Privacy() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => View(new ErrorVm { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
