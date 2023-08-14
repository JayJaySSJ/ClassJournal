using ClassJournal.AppCore.DependencyInjection;
using ClassJournal.Repository.DatabaseContext;
using ClassJournal.Repository.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

DatabaseContextConfig.ConfigureDbContext(builder);

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
});
AppCoreDependencyInjectionsConfig.ConfigureServices(builder.Services);
RepoDependencyInjectionsConfig.ConfigureServices(builder.Services);
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.MapControllers();

app.Run();