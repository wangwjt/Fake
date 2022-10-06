using AutoMapper;
using Fake.API.Dto;
using Fake.API.Models;

namespace Fake.API.Profiles
{
    public class TouristRouteProfile : Profile
    {
        public TouristRouteProfile()
        {
            // arg1: 源对象
            // arg2: 目标对象
            CreateMap<TouristRoute, TouristRouteDTO>() // CreateMap 会自动映射名字相同的字段
                // dest => dest.CreateTime : 指出特殊处理的目标字段       （dest：目标）
                // opt => opt.MapFrom(a => a.ToString()) : 特殊处理的操作 （opt：原始）
                .ForMember(dest => dest.CreateTime, opt => opt.MapFrom(src => src.ToString())); 
        }
    }
}
