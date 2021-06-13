namespace JTSystem.Domain.Statistics.Repositories
{
    using JTSystem.Domain.Common;
    using JTSystem.Domain.Statistics.Models;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IStatisticsDomainRepository : IDomainRepository<Statistics>
    {
        Task AddJudokaView(int judokaId, CancellationToken cancellationToken = default);

        Task AddTournamentView(int tournamentId, CancellationToken cancellationToken = default);
    }
}
