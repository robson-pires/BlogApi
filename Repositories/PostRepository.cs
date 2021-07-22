using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using BlogApi.Data;
using BlogApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogApi.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly IDataContext _context;
        public PostRepository(IDataContext context)
        {
            _context = context;
        }
        public async Task<Post> Get(int id) 
            {
                return await _context.Posts.FindAsync(id);
            }
        public async Task<IEnumerable<Post>> GetAll()
        {
            return await _context.Posts.ToListAsync();
        }
        public async Task Add(Post post) 
        {
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
        }
        public async Task Delete(int id) 
        {
            var postToDelete = await _context.Posts.FindAsync(id);
            if (postToDelete == null)
                throw new NullReferenceException();
            
            _context.Posts.Remove(postToDelete);
            await _context.SaveChangesAsync();
        }
    }
}