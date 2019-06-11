using HelloWorld;
using Microsoft.AspNetCore.Mvc;

namespace webapinetcoretemplate.Controllers
{
    [Route("api/HelloWorld")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        private readonly IGetData _getData; 
        public HelloWorldController(IGetData getData)
        {
            _getData = getData;
        }

        public IActionResult GetHelloWorld()
        {
            return Ok(_getData.GetHelloWorld());
        }
    }
}