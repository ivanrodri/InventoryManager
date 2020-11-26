
using AutoMapper;
using InventoryManager.Domain.Elements;
using InventoryManager.Application.Elements;

namespace InventoryManager.Application
{
    /// <summary>Clase de configuraciòn de Automapper.</summary>
    public class AutomapperProfiler : Profile
    {
        public AutomapperProfiler()
        {
            CreateMap<Element, ElementDto>();


        }
    }
}
