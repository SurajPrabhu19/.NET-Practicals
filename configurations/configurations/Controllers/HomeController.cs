using configurations.Options;
using Microsoft.AspNetCore.Mvc;

namespace configurations.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [Route("/config1")]
        public IActionResult Index()
        {
            ViewBag.MyKey = _configuration["MyKey"];
            ViewBag.RandomKey = _configuration.GetValue<string>("RandomKey", "Value doesnt exists -> default value added");
            // Way 1: to get data from Json
            //ViewBag.MyAppClientId = _configuration["MyAppData:client-id"];
            //ViewBag.MyAppClientSecret = _configuration["MyAppData:client-secret"];
            //ViewBag.MyAppProdEnv = _configuration["MyAppData:environments:prod"];

            // Way 2: to get data from Json
            IConfigurationSection MyAppSection = _configuration.GetSection("MyAppData");
            ViewBag.MyAppClientId = MyAppSection["client-id"];
            ViewBag.MyAppClientSecret = MyAppSection["client-secret"];
            ViewBag.MyAppProdEnv = MyAppSection["environments:prod"];

            // Way 3: to get data from Json section -> using Options pattern
            MyAppDataOptions options1 = _configuration.GetSection("MyAppData2").Get<MyAppDataOptions>();    // using .Get<OptionsClass>()
            
            MyAppDataOptions options2 = new MyAppDataOptions(); // using .Bind(OptionsClass Object)
            _configuration.GetSection("MyAppData2").Bind(options2);


            return View();
        }
    }
}
