using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CalcWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultiplyTwoController : ControllerBase
    {
        private readonly ILogger<MultiplyTwoController> _logger;
        public MultiplyTwoController(ILogger<MultiplyTwoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public double Get(double x, double y)
        {
            return x * y;
        }
    }
}
