using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CalcWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddTwoController : ControllerBase
    {
        private readonly ILogger<AddTwoController> _logger;
        public AddTwoController(ILogger<AddTwoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public double Get(double x, double y)
        {
            return x + y;
        }
    }
}
