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
            //return View();

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


        public IActionResult DeleteElement([FromForm] string nameElement)
        {
            System.Diagnostics.Debug.WriteLine("nameElement " + nameElement);

            return View("Delete");
        }

        public IActionResult Delete()
        {
            return View("Delete");
        }

    }
}
