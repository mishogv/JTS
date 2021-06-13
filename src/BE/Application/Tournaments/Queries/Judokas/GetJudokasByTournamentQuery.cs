namespace JTSystem.Application.Tournaments.Queries.Judokas
{
    using JTSystem.Application.Tournaments.Queries.Common;
    using MediatR;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class GetJudokasByTournamentQuery : IRequest<IEnumerable<JudokaOutputModel>>
    {
        public int TournamentId { get; set; }

        public class GetJudokasByTournamentQueryHandler : IRequestHandler<
           GetJudokasByTournamentQuery,
           IEnumerable<JudokaOutputModel>>
        {
            private readonly ITournamentQueryRepository tournamentQueryRepository;

            public GetJudokasByTournamentQueryHandler(ITournamentQueryRepository tournamentQueryRepository)
                => this.tournamentQueryRepository = tournamentQueryRepository;

            public async Task<IEnumerable<JudokaOutputModel>> Handle(
                GetJudokasByTournamentQuery request,
                CancellationToken cancellationToken)
                => await this.tournamentQueryRepository.GetJudokasByTournament(request.TournamentId, cancellationToken);
        }
    }
}
