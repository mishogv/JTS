namespace JTSystem.Application.Statistics
{
    using JTSystem.Application.Common.Contracts;
    using JTSystem.Application.Statistics.Queries.GetJudokaViewsQuery;
    using JTSystem.Application.Statistics.Queries.GetTournamentViewsQuery;
    using JTSystem.Domain.Statistics.Models;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IStatisticsQueryRepository : IQueryRepository<Statistics>
    {
        Task<IEnumerable<JudokaViewOutputModel>> GetJudokaViews(int judokaId, CancellationToken cancellationToken = default);

        Task<IEnumerable<TournamentViewOutputModel>> GetTournamentViews(int tournamentId, CancellationToken cancellationToken = default);
    }
}
