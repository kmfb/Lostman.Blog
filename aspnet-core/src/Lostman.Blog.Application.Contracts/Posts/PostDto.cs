using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Lostman.Blog.Posts
{
    public class PostDto : AuditedEntityDto<Guid>
    {
        public string Title { get; set; }
        public PostType Type { get; set; }
        public string Content { get; set; }
    }
}
