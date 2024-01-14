using Microsoft.AspNetCore.Mvc;
using ModelBinding_Validation.Models;
using System.Diagnostics.Eventing.Reader;

namespace ModelBinding_Validation.Controllers
{

    [Route("/")]
    //[Route("[controller]/[action]")]
    public class HomeController : Controller
    {

        [Route("{id?}/{isLoggedIn?}")]
        //public IActionResult Index([FromRoute]int? id, [FromRoute]bool? isLoggedIn=false)
        //public IActionResult Index([FromQuery]int? id, [FromQuery]bool? isLoggedIn=false)
        public IActionResult Index(Employee emp, int? id, bool? isLoggedIn = false)
        {
            if (id.HasValue == false && emp.id == 0)
                return BadRequest("Id is Null -> Please pass some Id value");

            if (isLoggedIn == false && emp.isLoggedIn == false)
                return Unauthorized($"Please login with a valid account for {emp.id}");

            return Content("Index Page");
        }
        [Route("check")]
        public IActionResult validateEmployee(Employee emp)
        {
            if (!ModelState.IsValid)
            {
                List<string> errors = new List<string>();
                foreach(var val in ModelState.Values)
                {
                    foreach(var error in val.Errors)
                        errors.Add(error.ErrorMessage.ToString());
                }
                string errorStr = String.Join(", ", errors);
                return BadRequest(errorStr);
            }

            return Content($"Employee Object validated - {emp}");
        }
        // FORM Fields: 
        // POST -> param in x-www-form-urlencoder >>> param passed as Route data - prefer when param count ~= 6 
        // POST -> param in multipart form-data >>> param passed as Route data - prefer for complex data + params >= 10 + send files

        // ORDER OF Data params passed in Model Binding:
        /* 1. Form fields - Multipart-form-data OR urlencoder-data
         * 2. Request Body - mostly JSON 
         * 3. Route Data e.g port/{id}/{isloggedin}
         * 4. Query String data e.g port?id=10&isloggedin=true
         */
    }
}
