using ClassJournal.AppCore.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassJournal.Repository.DatabaseContext
{
    public class UserContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }

        public UserContext(DbContextOptions<UserContext> contextOptions) : base(contextOptions)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().HasData(
                new UserModel()
                {
                    Id = 1,
                    Name = "admin",
                    Surname = "admin",
                    Email = "admin" + "@" + "admin.com",
                    Password = "admin",
                    BirthDate = new DateTime(1973, 01, 01),
                    Function = UserFunctionEnum.Admin
                });
        }
    }
}