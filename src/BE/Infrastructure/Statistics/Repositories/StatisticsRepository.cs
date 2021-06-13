namespace JTSystem.Infrastructure.Statistics.Repositories
{
    using JTSystem.Application.Statistics;
    using JTSystem.Domain.Statistics.Repositories;
    using JTSystem.Infrastructure.Common.Persistence;
    using JTSystem.Domain.Statistics.Models;
    using System.Threading.Tasks;
    using System.Threading;
    using Microsoft.EntityFrameworkCore;
    using JTSystem.Application.Statistics.Queries.GetJudokaViewsQuery;
    using JTSystem.Application.Statistics.Queries.GetTournamentViewsQuery;
    using System.Linq;
    using System.Collections.Generic;

    internal class StatisticsRepository : DataRepository<IStatisticsDbContext, Statistics>,
        IStatisticsDomainRepository,
        IStatisticsQueryRepository
    {
        public StatisticsRepository(IStatisticsDbContext dbContext) 
            : base(dbContext)
        {
        }

        public async Task AddJudokaView(int judokaId, CancellationToken cancellationToken = default)
        {
            var statistics = await this.All().SingleOrDefaultAsync(cancellationToken);

            statistics.AddJudokaView(judokaId);

            await this.Save(statistics, cancellationToken);
        }

        public async Task AddTournamentView(int tournamentId, CancellationToken cancellationToken = default)
        {
            var statistics = await this.All().SingleOrDefaultAsync(cancellationToken);

            statistics.AddTournamentView(tournamentId);

            await this.Save(statistics, cancellationToken);
        }

        public async Task<IEnumerable<JudokaViewOutputModel>> GetJudokaViews(int judokaId, CancellationToken cancellationToken = default)
        {
            var statistics = await this.All()
                .Include(x => x.JudokaViews)
                .SingleOrDefaultAsync(cancellationToken);

            return statistics.JudokaViews.Where(x => x.JudokaId == judokaId).Select(x => new JudokaViewOutputModel(x.JudokaId, x.When));

        }

        public async Task<IEnumerable<TournamentViewOutputModel>> GetTournamentViews(int tournamentId, CancellationToken cancellationToken = default)
        {
            var statistics = await this.All()
                .Include(x => x.TournamentViews)
                .SingleOrDefaultAsync(cancellationToken);

            return statistics.TournamentViews.Where(x => x.TournamentId == tournamentId).Select(x => new TournamentViewOutputModel(x.TournamentId, x.When));
        }
    }
}
