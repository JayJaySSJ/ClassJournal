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
    }
}