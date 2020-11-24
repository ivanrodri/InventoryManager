using InventoryManager.Application.Elements;
using InventoryManager.API.Models;
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
        readonly IElementService _elementService;

        public ElementController(ILogger<ElementController> logger, 
                                 IElementService elementService)
        {
            _logger = logger;
            _elementService = elementService;
        }


        [HttpGet]
        public Response<IEnumerable<ElementDto>> Get()
        {
            Response<IEnumerable<ElementDto>> response = new Response<IEnumerable<ElementDto>>();
            try
            {
                response.Object = _elementService.Get();
            }
            catch (Exception ex)
            {
                //log error
                response.Errored = true;
                response.ErrorMessage = ex.Message;
            }
            return response;



        }


    }
}
