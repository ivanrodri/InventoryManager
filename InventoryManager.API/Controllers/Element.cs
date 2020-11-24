using InventoryManager.API.Models;
using InventoryManager.Application.Elements;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace InventoryManager.API.Controllers
{
    /// <summary>Este controlador gestiona los métodos del elemento</summary>
    [ApiController]
    [Route("[controller]")]
    public class ElementController : ControllerBase
    {
        private readonly ILogger<ElementController> _logger;
        readonly IElementService _elementService;

        public ElementController(ILogger<ElementController> logger, 
                                 IElementService elementService)
        {
            _logger = logger;
            _elementService = elementService;
        }

        /// <summary>Este método permite añadir un elemento nuevo al inventario mediante la utilización de elementDto.</summary>
        /// <param name="elementDto">el neuvo elemtento</param>
        [HttpPost]
        public Response<ElementDto> Post(ElementDto elementDto)
        {
            Response<ElementDto> response = new Response<ElementDto>();
            try
            {
                response.Object = this._elementService.Add(elementDto);
            }
            catch (Exception ex)
            {
                response.Errored = true;
                response.ErrorMessage = ex.Message;
                _logger.LogError($"{typeof(ElementController).FullName}.{nameof(Post)}", elementDto);
            }
            return response;
        }

        /// <summary>Este método retorna todos loe elementos del inventario. Los elementos cancelados que se han sacado del inventario</summary>
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
                response.Errored = true;
                response.ErrorMessage = ex.Message;
                _logger.LogError($"{typeof(ElementController).FullName}.{nameof(Get)}", null);
            }
            return response;
        }

    }
}
