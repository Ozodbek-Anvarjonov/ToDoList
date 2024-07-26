﻿namespace ToDoList.Api.Configurations;

public static partial class HostConfigurations
{
    public static ValueTask<WebApplicationBuilder> ConfigureAsync(this WebApplicationBuilder builder)
    {
        builder
            .AddInfrastructure()
            .AddPersistence()
            .AddMapper()
            .AddDevTools()
            .AddExposers();

        return new ValueTask<WebApplicationBuilder>(builder);
    }

    public static ValueTask<WebApplication> ConfigureAsync(this WebApplication app)
    {
        app
            .UseDevTools()
            .UseExposers();

        return new ValueTask<WebApplication>(app);
    }
}