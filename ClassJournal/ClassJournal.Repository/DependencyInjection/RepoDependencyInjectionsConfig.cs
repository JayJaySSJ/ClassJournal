using ClassJournal.AppCore.Models;
using ClassJournal.AppCore.RepositoryDependencies;
using ClassJournal.Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;
//using RabbitMQ.Client;
//using IConnectionFactory = RabbitMQ.Client.IConnectionFactory;

namespace ClassJournal.Repository.DependencyInjection
{
    public class RepoDependencyInjectionsConfig
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services//.AddScoped<IConnectionFactory, ConnectionFactory>()     //TODO: Double-check to use or drop this step!!
                .AddScoped<IRepositoryBase<UserModel>, UserRepository>()
                .AddScoped<IRepositoryBase<ClassModel>, ClassRepository>()
                .AddScoped<IUserRepository, UserRepository>()
                .AddScoped<IClassRepository, ClassRepository>();
        }
    }
}