using System.Data.Entity;

namespace ProjectToSample
{
    public class Context : DbContext
    {
        public DbSet<Parent> Parents { get; set; }
    }
}