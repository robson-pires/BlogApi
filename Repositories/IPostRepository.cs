using System.Collections.Generic;
using System.Threading.Tasks;
using BlogApi.Models;

namespace BlogApi.Repositories
{
    public interface IPostRepository
    {
        Task<Post> Get(int id);
        Task<IEnumerable<Post>> GetAll();
        Task Add(Post post);
        Task Delete(int id);
    }
}