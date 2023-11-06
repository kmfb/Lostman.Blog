using Lostman.Blog.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Lostman.Blog
{
    public class PostDataSeederContributor
    : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Post, Guid> _postRepository;

        public PostDataSeederContributor(IRepository<Post, Guid> postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _postRepository.GetCountAsync() <= 0)
            {
                await _postRepository.InsertAsync(
                    new Post
                    {
                        Title = "first blog title",
                        Type = PostType.Tech,
                      
                        Content = "TEST CONTENT"
                    },
                    autoSave: true
                );

                await _postRepository.InsertAsync(
                    new Post
                    {
                        Title = "second blog title",
                        Type = PostType.Life,
                    
                        Content = "TEST CONTENT LIFE"
                    },
                    autoSave: true
                );
            }
        }
    }
}
