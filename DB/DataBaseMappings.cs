using AutoMapper;
using Core.Models;
using DB.Entities;

namespace DB
{
    public class DataBaseMappings : Profile
    {
        public DataBaseMappings() 
        {
            CreateMap<ActiveRouteEntity, ActiveRoute>();
            CreateMap<CarEntity, Car>();
            CreateMap<CargoEntity, Cargo>();
            CreateMap<CargoTypeEntity, CargoType>();
            CreateMap<DriverEntity, Driver>();
            CreateMap<RouteEntity, Route>();
        }
    }
}
