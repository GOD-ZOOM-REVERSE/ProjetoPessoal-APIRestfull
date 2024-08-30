using AutoMapper;
using ProjetoPessoal.Data.VOs;
using ProjetoPessoal.Model;

namespace ProjetoPessoal.Config
{
    public class MapperConfig
    {
        public MapperConfiguration MappingConfig()
        {
            var config = new MapperConfiguration(options =>
            {
                options.CreateMap<Product, ProductVO>();
                options.CreateMap<ProductVO, Product>();
            });
            return config;
        }
    }
}
