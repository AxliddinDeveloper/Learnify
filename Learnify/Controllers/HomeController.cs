using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Learnify.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController
    {
        [HttpGet]
        public string SayHello() =>
            "Hello World";
    }
}
