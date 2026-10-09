using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreApiDemo.Controllers
{
 //   [Route("api/[controller]")]
    [ApiController]
    public class SampleApiController : ControllerBase
    {

        [HttpGet]
        [Route("api/first")]
        public string firstApi()
        {
            return "Welcome to First Api";
        }
        [HttpPost]
        [Route("api/square/{id}")]
        public int SquareApi(int id)
        {
            int d = id * id;
            return d;
        }
        [HttpGet]
        [Route("api/cities")]
        public List<string> GetCities()
        {
            List<string> lst = new List<string>()
            {
                "Pune","Mumbai","Nashik","Nagpur"
            };
            return lst;
        }
    }
}
