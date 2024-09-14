using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models.MyContext
{
    public class TodoContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Todos;Integrated Security=True;Trust Server Certificate=True");


        public DbSet<Todo> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 

            modelBuilder.Entity<Todo>()
                        .Property(t=>t.IsCompleted).HasDefaultValue(false);

            modelBuilder.Entity<Todo>()
                        .Property(t => t.CreatedTime).HasDefaultValueSql("getdate()");


        }

    }
}
