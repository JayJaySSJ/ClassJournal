using ClassJournal.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassJournal.API.DatabaseContext
{
    public class ClassContext : DbContext
    {
        public DbSet<ClassModel> Classes { get; set; }

        public ClassContext(DbContextOptions contextOptions) : base(contextOptions) 
        {
        
        }
    }
}
