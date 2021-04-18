using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace CalcWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivideTwoController : ControllerBase
    {
        private readonly ILogger<DivideTwoController> _logger;
        public DivideTwoController(ILogger<DivideTwoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public double Get(double x, double y)
        {
            return y != 0.0d ? x / y : double.NaN;
        }
    }
}
