namespace JTSystem.Startup
{
    using JTSystem.Infrastructure.Common;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;

    public static class ApplicationSeeding
    {
        public static IApplicationBuilder UseSeeding(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();

            var seeders = serviceScope.ServiceProvider.GetServices<ISeeder>();

            foreach (var seeder in seeders)
            {
                seeder.Seed();
            }

            return app;
        }
    }
}
