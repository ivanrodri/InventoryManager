
using AutoMapper;
using InventoryManager.Domain.Elements;
using InventoryManager.Application.Elements;

namespace InventoryManager.Application
{
    public class AutomapperProfiler : Profile
    {
        public AutomapperProfiler()
        {
            CreateMap<Element, ElementDto>();


        }
    }
}
