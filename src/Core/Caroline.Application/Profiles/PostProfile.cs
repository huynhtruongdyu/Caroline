using AutoMapper;
using Caroline.Domain.Categories;
using Caroline.Shared.Models.Post;

namespace Caroline.Application.Profiles
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<Post, PostModel>().ReverseMap();
            CreateMap<Post, PostCreateModel>().ReverseMap();
        }
    }
}