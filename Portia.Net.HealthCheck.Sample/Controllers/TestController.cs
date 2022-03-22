using Microsoft.AspNetCore.Mvc;
using Portia.Net.HealthCheck.Core;

namespace Portia.Net.HealthCheck.Sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // A normal request track will be added for this API
            return Ok("Server is up");
        }

        [HttpGet("IgnoredAPI")]
        [HealthCheckIgnore]
        public IActionResult IgnoredAPI()
        {
            // No request track will be created for this API
            return Ok();
        }

        [HttpGet("CheckKnownException")]
        public IActionResult CheckKnownException()
        {
            // The request track should be created with HadError = false
            throw new KnownException("Invalid Key");
        }

        [HttpGet("CheckUnknownException")]
        public IActionResult CheckUnknownException()
        {
            // The request track should be created with HadError = true
            throw new Exception("Operation failed.");
        }
    }
}