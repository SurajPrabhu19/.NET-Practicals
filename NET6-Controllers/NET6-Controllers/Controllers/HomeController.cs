using Microsoft.AspNetCore.Mvc;

namespace NET6_Controllers.Controllers
{
    public class HomeController // always keep the name ending with controller for compiler to detect it as a controller
    {
        public string Index()
        {
            return "New Controller";
        }
    }
}
