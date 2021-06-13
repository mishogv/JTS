namespace JTSystem.Infrastructure.Common.Persistence.Seeders
{
    using JTSystem.Infrastructure.Identity;
    using Microsoft.AspNetCore.Identity;
    using System.Linq;

    internal class UserSeeder : ISeeder
    {
        private readonly UserManager<User> userManager;
        private readonly TournamentsDbContext dbContext;

        public UserSeeder(UserManager<User> userManager, TournamentsDbContext dbContext)
        {
            this.userManager = userManager;
            this.dbContext = dbContext;
        }

        public void Seed()
        {
            if (!userManager.Users.Any())
            {
                var user = new User("admin@admin.com");

                var password = "admin123123";

                userManager.CreateAsync(user, password).GetAwaiter().GetResult();

                this.dbContext.SaveChangesAsync().GetAwaiter().GetResult();
            }
        }
    }
}
