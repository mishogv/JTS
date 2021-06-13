namespace JTSystem.Application.Tournaments.Queries.Tournaments
{
    using Common;
    using MediatR;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class GetTournamentsQuery : IRequest<IEnumerable<TournamentOutputModel>>
    {
        public class GetCarAdCategoriesQueryHandler : IRequestHandler<
            GetTournamentsQuery,
            IEnumerable<TournamentOutputModel>>
        {
            private readonly ITournamentQueryRepository tournamentQueryRepository;

            public GetCarAdCategoriesQueryHandler(ITournamentQueryRepository tournamentQueryRepository)
                => this.tournamentQueryRepository = tournamentQueryRepository;

            public async Task<IEnumerable<TournamentOutputModel>> Handle(
                GetTournamentsQuery request,
                CancellationToken cancellationToken)
                => await this.tournamentQueryRepository.AllTournaments(cancellationToken);
        }
    }
}
