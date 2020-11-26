
using AutoMapper;
using InventoryManager.Domain.Elements;
using InventoryManager.Application.Elements;
using InventoryManager.WebMVC.Models;

namespace InventoryManager.WebMVC
{
    /// <summary>Clase de configuración de Automapper.</summary>
    public class AutomapperProfiler : Profile
    {
        public AutomapperProfiler()
        {
            CreateMap<Element, ElementDto>();
            CreateMap<ElementDto, Element>();


            CreateMap<ElementViewModel, ElementDto>();
            CreateMap<ElementDto, ElementViewModel>();

        }
    }
}
