using AutoMapper;
using Caroline.Domain.Categories;
using Caroline.Shared.Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caroline.Application.Profiles
{
    public class PostProfile:Profile
    {
        public PostProfile()
        {
            CreateMap<Post, PostModel>().ReverseMap();
            CreateMap<Post, PostCreateModel>().ReverseMap();
        }
    }
}
