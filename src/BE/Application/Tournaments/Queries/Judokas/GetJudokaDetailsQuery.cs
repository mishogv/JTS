namespace JTSystem.Application.Tournaments.Queries.Judokas
{
    using JTSystem.Application.Tournaments.Queries.Common;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class GetJudokaDetailsQuery : IRequest<JudokaOutputModel>
    {
        public int Id { get; set; }

        public class GetJudokaDetailsQueryHandler : IRequestHandler<
            GetJudokaDetailsQuery,
            JudokaOutputModel>
        {
            private readonly ITournamentQueryRepository tournamentQueryRepository;

            public GetJudokaDetailsQueryHandler(ITournamentQueryRepository tournamentQueryRepository)
                => this.tournamentQueryRepository = tournamentQueryRepository;

            public async Task<JudokaOutputModel> Handle(
                GetJudokaDetailsQuery request,
                CancellationToken cancellationToken)
                => await this.tournamentQueryRepository.GetJudokaDetails(request.Id, cancellationToken);
        }
    }
}
