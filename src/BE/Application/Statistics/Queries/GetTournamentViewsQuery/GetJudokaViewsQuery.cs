namespace JTSystem.Application.Statistics.Queries.GetTournamentViewsQuery
{
    using MediatR;
    using System.Threading.Tasks;
    using System.Threading;
    using System.Collections.Generic;

    public class GetTournamentViewsQuery : IRequest<IEnumerable<TournamentViewOutputModel>>
    {
        public int Id { get; set; }

        public class GetTournamentViewsQueryHandler : IRequestHandler<
            GetTournamentViewsQuery,
            IEnumerable<TournamentViewOutputModel>>
        {
            private readonly IStatisticsQueryRepository statisticsQueryRepository;

            public GetTournamentViewsQueryHandler(IStatisticsQueryRepository statisticsQueryRepository)
                => this.statisticsQueryRepository = statisticsQueryRepository;

            public async Task<IEnumerable<TournamentViewOutputModel>> Handle(
                GetTournamentViewsQuery request,
                CancellationToken cancellationToken)
                => await this.statisticsQueryRepository.GetTournamentViews(request.Id, cancellationToken);
        }
    }
}
