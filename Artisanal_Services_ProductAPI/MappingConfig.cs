using Artisanal_Services_ProductAPI.Models;
using Artisanal_Services_ProductAPI.Models.Dto;
using AutoMapper;

namespace Artisanal_Services_ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfiguration = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });

            return mappingConfiguration;
        }
    }
}
