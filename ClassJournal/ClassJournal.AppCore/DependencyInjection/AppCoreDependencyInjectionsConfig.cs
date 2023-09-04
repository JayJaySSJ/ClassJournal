using ClassJournal.AppCore.Handlers;
using ClassJournal.AppCore.Interfaces;
using ClassJournal.AppCore.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ClassJournal.AppCore.DependencyInjection
{
    public class AppCoreDependencyInjectionsConfig
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services
                .AddScoped<IClassService, ClassService>()
                .AddScoped<IUserService, UserService>()
                .AddScoped<IUserHandler, UserHandler>();
        }
    }
}