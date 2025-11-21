using AskTyler.DataAccess;
using AskTyler.Settings;
using Microsoft.EntityFrameworkCore;

namespace AskTyler.IoC;

public static class DbContextConfigurator
{
    public static void ConfigureService(IServiceCollection services, AskTylerSettings settings)
    {
        services.AddDbContextFactory<AskTylerDbContext>(
            options => { options.UseNpgsql(settings.AskTylerDbContextConnectionString); },
            ServiceLifetime.Scoped);
    }

    public static void ConfigureApplication(IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var contextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<AskTylerDbContext>>();
        using var context = contextFactory.CreateDbContext();
        context.Database.Migrate(); //makes last migrations to db and creates database if it doesn't exist
    }
}