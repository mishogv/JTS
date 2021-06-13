namespace JTSystem.Application.Statistics.Handlers
{
    using JTSystem.Application.Common;
    using JTSystem.Domain.Statistics.Repositories;
    using JTSystem.Domain.Tournaments.Events;
    using System.Threading.Tasks;

    public class TournamentViewedEventHandler : IEventHandler<TournamentViewedEvent>
    {
        private readonly IStatisticsDomainRepository statistics;
        public TournamentViewedEventHandler(IStatisticsDomainRepository statistics)
        {
            this.statistics = statistics;
        }

        public async Task Handle(TournamentViewedEvent tournamentViewedEvent)
        {
            await this.statistics.AddTournamentView(tournamentViewedEvent.TournamentId);
        }
    }
}
