using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlogApi.Models;

namespace BlogApi.Data
{
    public interface IDataContext
    {
        DbSet<Post> Posts { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    }
}