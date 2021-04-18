using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CalcWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntToHexController : ControllerBase
    {
        private readonly ILogger<IntToHexController> _logger;
        public IntToHexController(ILogger<IntToHexController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get(int number)
        {
            return number.ToString("X");
        }
    }
}
