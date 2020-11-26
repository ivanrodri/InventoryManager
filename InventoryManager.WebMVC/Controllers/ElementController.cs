using InventoryManager.Application.Elements;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManager.WebMVC.Controllers
{
    public class ElementController : Controller
    {
        public IActionResult Index()
        {
            return View("List");
        }

        public IActionResult New()
        {
            return View("New");
        }

        public RedirectToActionResult AddElement([FromForm] ElementDto element)
        {




            return RedirectToAction(actionName: "Index");
        }


    }
}
