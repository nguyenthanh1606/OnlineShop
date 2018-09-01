using AutoMapper;
using OnlineShop.Model.Models;
using OnlineShop.Web.Models;

namespace OnlineShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Post, PostVM>();
            Mapper.CreateMap<PostCategory, PostCategoryVM>();
            Mapper.CreateMap<PostTag, PostTagVM>();
            Mapper.CreateMap<Product, ProductVM>();
            Mapper.CreateMap<ProductCategory, ProductCategoryVM>();
            Mapper.CreateMap<ProductTag, ProductTagVM>();
            Mapper.CreateMap<Tag, TagVM>();
        }
    }
}