using Microsoft.EntityFrameworkCore;
using System.Reflection;
using ToDoList.Application.Services;
using ToDoList.Infrastructure.Services;
using ToDoList.Persistence.DataContext;
using ToDoList.Persistence.Repositories;
using ToDoList.Persistence.Repositories.Interfaces;

namespace ToDoList.Api.Configurations;

public static partial class HostConfigurations
{
    private static readonly ICollection<Assembly> Assemblies;

    static HostConfigurations()
    {
        Assemblies = Assembly.GetExecutingAssembly().GetReferencedAssemblies().Select(Assembly.Load).ToList();
        Assemblies.Add(Assembly.GetExecutingAssembly());
    }


    private static WebApplicationBuilder AddPersistence(this WebApplicationBuilder builder)
    {
        builder.Services
            .AddDbContext<ToDoListDbContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
        builder.Services
            .AddScoped<IToDoListRepository, ToDoListRepository>();

        return builder;
    }

    private static WebApplicationBuilder AddInfrastructure(this WebApplicationBuilder builder)
    {
        builder.Services
            .AddScoped<IToDoListService, ToDoListService>();

        return builder;
    }

    private static WebApplicationBuilder AddMapper(this WebApplicationBuilder builder)
    {
        builder.Services
            .AddAutoMapper(Assemblies);

        return builder;
    }


    private static WebApplicationBuilder AddDevTools(this  WebApplicationBuilder builder)
    {
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        return builder;
    }

    private static WebApplicationBuilder AddExposers(this WebApplicationBuilder builder)
    {
        builder.Services.AddRouting(options => options.LowercaseUrls = true);
        builder.Services.AddControllers();

        return builder;
    }

    private static WebApplication UseDevTools(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();

        return app;
    }

    private static WebApplication UseExposers(this WebApplication app)
    {
        app.MapControllers();

        return app;
    }
}