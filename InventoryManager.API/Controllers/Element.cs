using InventoryManager.Application.Elements;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManager.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ElementController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ElementController> _logger;

        public ElementController(ILogger<ElementController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public IEnumerable<ElementDto> Get()
        {
   

         

        }


    }
}
