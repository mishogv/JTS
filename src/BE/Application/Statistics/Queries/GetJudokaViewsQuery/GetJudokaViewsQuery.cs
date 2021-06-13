namespace JTSystem.Application.Statistics.Queries.GetJudokaViewsQuery
{
    using MediatR;
    using System.Threading.Tasks;
    using System.Threading;
    using System.Collections.Generic;

    public class GetJudokaViewsQuery : IRequest<IEnumerable<JudokaViewOutputModel>>
    {
        public int Id { get; set; }

        public class GetJudokaViewsQueryHandler : IRequestHandler<
            GetJudokaViewsQuery,
            IEnumerable<JudokaViewOutputModel>>
        {
            private readonly IStatisticsQueryRepository statisticsQueryRepository;

            public GetJudokaViewsQueryHandler(IStatisticsQueryRepository statisticsQueryRepository)
                => this.statisticsQueryRepository = statisticsQueryRepository;

            public async Task<IEnumerable<JudokaViewOutputModel>> Handle(
                GetJudokaViewsQuery request,
                CancellationToken cancellationToken)
                => await this.statisticsQueryRepository.GetJudokaViews(request.Id, cancellationToken);
        }
    }
}
