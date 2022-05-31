using AutoMapper;
using Shop.Services.PhoneAPI.Models;

namespace Shop.Services.PhoneAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<GoodsDto, Goods>();
                config.CreateMap<Goods, GoodsDto>();
            });
            return mappingConfig;
        }
    }
}
