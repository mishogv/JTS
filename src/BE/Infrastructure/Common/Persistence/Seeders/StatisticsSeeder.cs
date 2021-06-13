namespace JTSystem.Infrastructure.Common.Persistence.Seeders
{
    using Microsoft.EntityFrameworkCore;
    using JTSystem.Domain.Statistics.Models;

    internal class StatisticsSeeder : ISeeder
    {
        private readonly TournamentsDbContext dbContext;

        public StatisticsSeeder(TournamentsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Seed()
        {
            var statistics = this.dbContext.Statistics.FirstOrDefaultAsync().GetAwaiter().GetResult();

            if (statistics == null)
            {
                var statisticsToAdd = new Statistics();

                this.dbContext.Statistics.Add(statisticsToAdd);
                this.dbContext.SaveChangesAsync().GetAwaiter().GetResult();
            }
        }
    }
}
