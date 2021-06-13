namespace JTSystem.Application.Tournaments.Queries.Details
{
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class GetTournamentDetailsQuery : IRequest<TournamentDetailsOutputModel>
    {
        public int Id { get; set; }

        public class GetTournamentDetailsQueryHandler : IRequestHandler<
            GetTournamentDetailsQuery,
            TournamentDetailsOutputModel>
        {
            private readonly ITournamentQueryRepository tournamentQueryRepository;

            public GetTournamentDetailsQueryHandler(ITournamentQueryRepository tournamentQueryRepository)
                => this.tournamentQueryRepository = tournamentQueryRepository;

            public async Task<TournamentDetailsOutputModel> Handle(
                GetTournamentDetailsQuery request,
                CancellationToken cancellationToken)
                => await this.tournamentQueryRepository.GetTournamentDetails(request.Id, cancellationToken);
        }
    }
}
