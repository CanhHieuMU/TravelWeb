using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TravelWeb.Data;
using TravelWeb.Models;

namespace TravelWeb.Controllers
{
    public class HomeController : Controller
    {
        TravelDbContext travelDbContext;

        public HomeController(Data.TravelDbContext _travelDbContext)
        {
            this.travelDbContext = _travelDbContext;
        }

        public IActionResult Index()
        {
            /*Codeluoncholong'
             * var i = travelDbContext.Cuisines.Where(c => c.Rates < 8)
              */ 
            var t = travelDbContext.Cuisines
                .Where(c => c.CuisineId == 1)
                .Select(C => C.CuisineName);
               
            return Json(t);
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