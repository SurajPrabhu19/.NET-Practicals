using Microsoft.AspNetCore.Mvc;
using StocksApp.Services;

namespace StocksApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly StockService _stockService;

        public HomeController(StockService stockService)
        {
            _stockService = stockService;
        }
        public async Task<IActionResult> Index()
        {
            await _stockService.Method();
            return View();
        }


    }
}
