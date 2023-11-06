using Lostman.Blog.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Lostman.Blog.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BlogController : AbpControllerBase
{
    protected BlogController()
    {
        LocalizationResource = typeof(BlogResource);
    }
}
