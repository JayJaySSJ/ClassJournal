using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ClassJournal.Repository.DatabaseContext
{
    public class DatabaseContextConfig
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