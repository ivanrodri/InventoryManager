﻿using InventoryManager.Application.Elements;
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
            return View();
        }

        public IActionResult List()
        {
            List<ElementDto> ElementsDto = new List<ElementDto>();

            try
            {
                _elementService.Get();
 
            }
            catch (Exception ex)
            {

                return RedirectToAction(actionName: "Index");

            }
            return View(ElementsDto);
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

            return RedirectToAction(actionName: "Index");
        }


    }
}
