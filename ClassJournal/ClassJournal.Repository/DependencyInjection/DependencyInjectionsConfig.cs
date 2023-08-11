using ClassJournal.API.Models;
using ClassJournal.API.RepositoryDependencies;
using ClassJournal.Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;
//using RabbitMQ.Client;
//using IConnectionFactory = RabbitMQ.Client.IConnectionFactory;

namespace ClassJournal.Repository.DependencyInjection
{
    public class DependencyInjectionsConfig
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services//.AddScoped<IConnectionFactory, ConnectionFactory>()     //TODO: Double-check to use or drop this step!!
                .AddScoped<IClassJournalRepository<UserModel>, UserRepository>()
                .AddScoped<IClassJournalRepository<ClassModel>, ClassRepository>();
        }
    }
}