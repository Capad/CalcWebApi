using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CalcWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubtractTwoController : ControllerBase
    {
        private readonly ILogger<SubtractTwoController> _logger;
        public SubtractTwoController(ILogger<SubtractTwoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public double Get(double x, double y)
        {
            return x - y;
        }
    }
}
