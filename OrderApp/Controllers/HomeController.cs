using Dapper;
using Microsoft.AspNetCore.Mvc;
using OrderApp.Models;
using System.Data.SQLite;
using System.Diagnostics;

namespace OrderApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            using var connection = new SQLiteConnection("Data Source= DemoDB.db");
            var sql = "SELECT * FROM ORDERS";
            var results = connection.QueryAsync<Orders>(sql);
            return View();
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
