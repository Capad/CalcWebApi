using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Globalization;

namespace CalcWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HexToIntController : ControllerBase
    {
        private readonly ILogger<HexToIntController> _logger;
        public HexToIntController(ILogger<HexToIntController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public int Get(string hex)
        {
            return int.Parse(hex, NumberStyles.HexNumber);
        }
    }
}
