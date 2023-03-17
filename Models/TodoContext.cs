using Microsoft.EntityFrameworkCore;

namespace WebApiTODO.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<Login>? Logins { get; set; }

    }
}
