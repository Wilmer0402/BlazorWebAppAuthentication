using BlazorWebAppAuthentication.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebAppAuthentication.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base (options) { }
        
        public DbSet<UserAccount> UserAccount { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserAccount>().HasData(new List<UserAccount>()
                {
                  new UserAccount() {Id = 1, UserName= "Wilmer", Password="Will04", Role ="Admin" },
                  new UserAccount() {Id = 2, UserName = "Juan", Password = "Perez05", Role = "User" }
            });
        }
    }
}
