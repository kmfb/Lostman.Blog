using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Lostman.Blog.Posts
{
    public class Post : AuditedAggregateRoot<Guid>
    {
        public string Title { get; set; }
        public PostType Type { get; set; }
        public string Content { get; set; }
    }
}
