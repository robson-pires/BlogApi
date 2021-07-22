using Microsoft.EntityFrameworkCore;
using BlogApi.Models;

namespace BlogApi.Data
{
    public class DataContext : DbContext, IDataContext 
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) 
        {
            
        }

        public DbSet<Post> Posts { get; set; }
    }
}