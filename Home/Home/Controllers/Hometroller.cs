using Microsoft.AspNetCore.Mvc;

namespace Home.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Hometroller : ControllerBase
    {

        [HttpGet(Name = "Values")]
        public string Get()
        {
            return "Hello World";
        }
    }
}