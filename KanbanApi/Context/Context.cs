using KanbanApi.Model;
using Microsoft.EntityFrameworkCore;

namespace KanbanApi
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options) { }

        public DbSet<Card> Cards { get; set; }
    }
}
