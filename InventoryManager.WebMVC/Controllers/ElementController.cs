using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

         public RedirectToActionResult AddElement()
        {

            return RedirectToAction("Index");
        }

    }
}
