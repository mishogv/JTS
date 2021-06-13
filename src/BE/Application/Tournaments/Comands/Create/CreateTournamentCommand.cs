namespace JTSystem.Application.Tournaments.Comands.Create
{
    using Common;
    using JTSystem.Domain.Tournaments.Factories.Tournaments;
    using JTSystem.Domain.Tournaments.Repositories;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class CreateTournamentCommand : TournamentCommand<CreateTournamentCommand>, IRequest<CreateTournamentOutputModel>
    {
        public class CreateTournamentCommandHandler : IRequestHandler<CreateTournamentCommand, CreateTournamentOutputModel>
        {
            private readonly ITournamentDomainRepository tournamentDomainRepository;
            private readonly ITournamentFactory tournamentFactory;

            public CreateTournamentCommandHandler(
                ITournamentDomainRepository tournamentDomainRepository,
                ITournamentFactory tournamentFactory)
            {
                this.tournamentDomainRepository = tournamentDomainRepository;
                this.tournamentFactory = tournamentFactory;
            }

            public async Task<CreateTournamentOutputModel> Handle(CreateTournamentCommand request, CancellationToken cancellationToken)
            {
                var tournament = this.tournamentFactory
                    .WithName(request.Name)
                    .WithWinPrize(request.WinPrize)
                    .WithLocation(request.Location)
                    .WithStartDate(request.StartDate)
                    .WithEndDate(request.EndDate)
                    .Build();


                await this.tournamentDomainRepository.Save(tournament, cancellationToken);

                return new CreateTournamentOutputModel(tournament.Id);
            }
        }
    }
}
