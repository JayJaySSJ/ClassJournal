using ClassJournal.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassJournal.Repository.DatabaseContext
{
    public class ClassContext : DbContext
    {
        public DbSet<ClassModel> Classes { get; set; }

        public ClassContext(DbContextOptions<ClassContext> contextOptions) : base(contextOptions) 
        {
        
        }
    }
}