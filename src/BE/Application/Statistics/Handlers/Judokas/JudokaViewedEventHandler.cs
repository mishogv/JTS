namespace JTSystem.Application.Statistics.Handlers.Judokas
{
    using JTSystem.Domain.Tournaments.Events;
    using JTSystem.Application.Common;
    using System.Threading.Tasks;
    using JTSystem.Domain.Statistics.Repositories;

    public class JudokaViewedEventHandler : IEventHandler<JudokaViewedEvent>
    {
        private readonly IStatisticsDomainRepository statistics;

        public JudokaViewedEventHandler(IStatisticsDomainRepository statistics)
        {
            this.statistics = statistics;
        }

        public async Task Handle(JudokaViewedEvent judokaViewedEvent)
        {
            await this.statistics.AddJudokaView(judokaViewedEvent.JudokaId);
        }
    }
}
