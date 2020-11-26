using InventoryManager.Application.Elements;
using Microsoft.AspNetCore.Mvc;

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
            return View("List");
        }

        public IActionResult New()
        {
            return View("New");
        }

        public RedirectToActionResult AddElement([FromForm] ElementDto elementDto)
        {
            
           
            _elementService.Add(elementDto);


            return RedirectToAction(actionName: "Index");
        }


    }
}
