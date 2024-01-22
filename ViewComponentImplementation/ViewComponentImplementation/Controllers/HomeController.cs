using Microsoft.AspNetCore.Mvc;
using ViewComponentImplementation.Models;

namespace ViewComponentImplementation.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/about")]
        public IActionResult About()
        {
            return View();
        }

        [Route("/person-details")]
        public IActionResult PersonDetails()
        {
            List<PersonModel> personModelList = new List<PersonModel>()
            {
                new PersonModel(){Name = "Suraj", Designation="Sr. SWE"},
                new PersonModel(){Name = "Nitin", Designation="SDE-2"}
            };
            //ViewData["model"] = personModelList;

            return View("PersonDetails", model:personModelList);
        }


    }
}
