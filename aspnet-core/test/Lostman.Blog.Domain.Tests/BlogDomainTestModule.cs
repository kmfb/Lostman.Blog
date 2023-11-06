using Lostman.Blog.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Lostman.Blog;

[DependsOn(
    typeof(BlogEntityFrameworkCoreTestModule)
    )]
public class BlogDomainTestModule : AbpModule
{

}
