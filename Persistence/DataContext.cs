using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }
        
        //Represents a Table in the Database called 'Activities'
        public DbSet<Activity> Activities { get; set; }
    }
}