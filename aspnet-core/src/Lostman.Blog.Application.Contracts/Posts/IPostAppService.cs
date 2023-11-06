using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Lostman.Blog.Posts
{
    public interface IPostAppService: ICrudAppService<
        PostDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdatePostDto
        >
    {

    }
}
