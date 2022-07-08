using EmissorCteWebAsp.net6._0.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmissorCteWebAsp.net6._0.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeModel home = new HomeModel();
            home.Nome = "Visitante";
            home.Email = "Vazio";

            return View(home);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}