using Microsoft.EntityFrameworkCore;
using WebApiExample.Models;

namespace WebApiExample
{

    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-UN8K0C5\\SQLEXPRESS;Database=TestWebApi;Trusted_Connection=True;");
        }
    }

}
