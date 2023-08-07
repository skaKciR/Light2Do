using Light2Do.Shared;
using Microsoft.EntityFrameworkCore;

namespace Light2Do.Server.Domain
{
    public class AppDbContext:DbContext
    {
        public DbSet<TodoItems> TodoItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseInMemoryDatabase(databaseName: "Light2DoDB");

        }
    }
}
