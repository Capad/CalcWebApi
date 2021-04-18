using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace CalcWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BinToIntController : ControllerBase
    {
        private readonly ILogger<BinToIntController> _logger;
        public BinToIntController(ILogger<BinToIntController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public int Get(string bin)
        {
            return Convert.ToInt32(bin, 2);
        }
    }
}
