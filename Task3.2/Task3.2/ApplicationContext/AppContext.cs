using Microsoft.EntityFrameworkCore;
using Task3._2.Models;

namespace Task3._2.ApplicationContext
{
    public class AppContext : DbContext
    {
       public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=TaskTest;Integrated Security=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }


    }
}
