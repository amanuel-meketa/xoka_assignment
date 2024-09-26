using hr.api.Model;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {}

        public DbSet<Employee> Employee { get; set; }
    }
}
