using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NuBankAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankAPIController : ControllerBase
    {
        private readonly ILogger<BankAPIController> _logger;

        public BankAPIController(ILogger<BankAPIController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<BankTransaction> Get()
        {
            //TODO
            return null;
        }
    }
}
