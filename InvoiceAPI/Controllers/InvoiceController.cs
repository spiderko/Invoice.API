using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace InvoiceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvoiceController : ControllerBase
    {
        private readonly ILogger<InvoiceController> _logger;

        public InvoiceController(ILogger<InvoiceController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Invoice> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Invoice
            {
                Date = DateTime.Now.AddDays(-index),
                Value = index * 10,
                Reference = $"{index}-12345-{index}"
            })
            .ToArray();
        }
    }
}
