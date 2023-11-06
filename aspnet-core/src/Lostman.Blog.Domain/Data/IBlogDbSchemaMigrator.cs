using System.Threading.Tasks;

namespace Lostman.Blog.Data;

public interface IBlogDbSchemaMigrator
{
    Task MigrateAsync();
}
