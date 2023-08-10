using Microsoft.EntityFrameworkCore;

namespace ClassJournal.API.DatabaseContext
{
    class DatabaseContextConfig
    {
        public static void ConfigureDbContext(WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<UserContext>(context =>
            {
                context.UseSqlServer(builder.Configuration.GetConnectionString("ClassJournalDB"));
            });

            builder.Services.AddDbContext<ClassContext>(context =>
            {
                context.UseSqlServer(builder.Configuration.GetConnectionString("ClassJournalDB"));
            });
        }
    }
}