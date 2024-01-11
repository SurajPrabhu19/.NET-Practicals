using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitController : ControllerBase
    {
        public List<string> fruits = new List<string>()
        {
            "Apple", "Banana", "Kiwi", "Melon"
        };

        [HttpGet]
        public List<string> getFruits()
        {
            return fruits;
        }
        [HttpGet("{id}")]
        public string getFruitById(int id)
        {
            int len = fruits.Count;
            if(id>=0 && id<len)
                return fruits.ElementAt(id);
            return "Fruit Not found";
        }
    }
}
