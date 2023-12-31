﻿using AutoMapper;
using Lostman.Blog.Posts;

namespace Lostman.Blog;

public class BlogApplicationAutoMapperProfile : Profile
{
    public BlogApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Post, PostDto>();
        CreateMap<CreateUpdatePostDto, Post>();
    }
}
