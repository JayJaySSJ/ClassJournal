using ClassJournal.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassJournal.API.DatabaseContext
{
    public class TrainerContext : DbContext
    {
        public DbSet<TrainerModel> Trainers { get; set; }

        public TrainerContext(DbContextOptions contextOptions) : base(contextOptions)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrainerModel>().HasData(
                new TrainerModel()
                { 
                    Id = 1,
                    Name = "NameTest1",
                    Surname = "SurnameTest1",
                },
                new TrainerModel()
                {
                    Id = 2,
                    Name = "NameTest2",
                    Surname = "SurnameTest2",
                });
        }
    }
}