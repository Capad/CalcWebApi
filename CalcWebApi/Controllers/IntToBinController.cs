using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace CalcWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntToBinController : ControllerBase
    {
        private readonly ILogger<IntToBinController> _logger;
        public IntToBinController(ILogger<IntToBinController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get(int number)
        {
            return Convert.ToString(number, 2);
        }
    }
}
