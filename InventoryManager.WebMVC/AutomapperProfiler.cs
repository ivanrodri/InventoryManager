
using AutoMapper;
using InventoryManager.Domain.Elements;
using InventoryManager.Application.Elements;

namespace InventoryManager.WebMVC
{
    /// <summary>Clase de configuración de Automapper.</summary>
    public class AutomapperProfiler : Profile
    {
        public AutomapperProfiler()
        {
            CreateMap<Element, ElementDto>();
            CreateMap<ElementDto, Element>();


        }
    }
}
