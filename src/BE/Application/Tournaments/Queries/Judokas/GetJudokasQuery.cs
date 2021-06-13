namespace JTSystem.Application.Tournaments.Queries.Judokas
{
    using JTSystem.Application.Tournaments.Queries.Common;
    using MediatR;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class GetJudokasQuery : IRequest<IEnumerable<JudokaOutputModel>>
    {
        public class GetJudokasQueryHandler : IRequestHandler<
            GetJudokasQuery,
            IEnumerable<JudokaOutputModel>>
        {
            private readonly ITournamentQueryRepository tournamentQueryRepository;

            public GetJudokasQueryHandler(ITournamentQueryRepository tournamentQueryRepository)
                => this.tournamentQueryRepository = tournamentQueryRepository;

            public async Task<IEnumerable<JudokaOutputModel>> Handle(
                GetJudokasQuery request,
                CancellationToken cancellationToken)
                => await this.tournamentQueryRepository.AllJudokas(cancellationToken);
        }
    }
}
