using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace web2.Controllers
{
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpGet]
        [Route("/foo")]
        // [Authorize]
        public string Foo([FromQuery, Required] int count)
        {
            var a = ModelState.IsValid;
            
            return "foo";
        }
    }
}