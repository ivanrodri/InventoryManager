using InventoryManager.Application.Elements;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace InventoryManager.WebMVC.Controllers
{
    public class ElementController : Controller
    {
        readonly IElementService _elementService;
     

        public ElementController(IElementService elementService)
        {
            _elementService = elementService;
        }

        public IActionResult Index()
        {
            return RedirectToAction("List", "Element");
        }

        public IActionResult List()
        {

            IEnumerable<ElementDto> elementsDto;
            try
            {
                elementsDto = _elementService.Get();
            }
            catch (Exception ex)
            {
                return RedirectToAction(actionName: "Index");
            }
            return View(elementsDto);
        }
         
        public IActionResult New()
        {
            return View("New");
        }

        public RedirectToActionResult AddElement([FromForm] ElementDto elementDto)
        {
            try
            {
                _elementService.Add(elementDto);
 
            }
            catch (Exception ex)
            {
                return RedirectToAction(actionName: "New");
            }         

            return RedirectToAction("List", "Element");
        }

        [HttpPost]
        public IActionResult DeleteElement([FromForm] string nameElement)
        {
            try
            {
                _elementService.Delete(nameElement);

            }
            catch (Exception ex)
            {
                return RedirectToAction(actionName: "Delete");
            }
            return RedirectToAction(actionName: "List");
        }

        public IActionResult Delete()
        {
            return View("Delete");
        }

    }
}
