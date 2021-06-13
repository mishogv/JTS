namespace JTSystem.Application.Tournaments.Comands.Edit
{
    using JTSystem.Application.Tournaments.Comands.Common;
    using JTSystem.Domain.Tournaments.Factories.Tournaments;
    using JTSystem.Domain.Tournaments.Repositories;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class EditTournamentCommand : TournamentCommand<EditTournamentCommand>, IRequest<EditTournamentOutputModel>
    {
        public class EditTournamentCommandHandler : IRequestHandler<EditTournamentCommand, EditTournamentOutputModel>
        {
            private readonly ITournamentDomainRepository tournamentDomainRepository;
            private readonly ITournamentFactory tournamentFactory;

            public EditTournamentCommandHandler(
                ITournamentDomainRepository tournamentDomainRepository,
                ITournamentFactory tournamentFactory)
            {
                this.tournamentDomainRepository = tournamentDomainRepository;
                this.tournamentFactory = tournamentFactory;
            }

            public async Task<EditTournamentOutputModel> Handle(EditTournamentCommand request, CancellationToken cancellationToken)
            {
                var tournament = await this.tournamentDomainRepository.Find(request.Id, cancellationToken);

                tournament.UpdateInfromation(request.Name, request.WinPrize, request.Location, request.StartDate, request.EndDate);

                await this.tournamentDomainRepository.Save(tournament, cancellationToken);

                return new EditTournamentOutputModel(tournament.Id, tournament.WinPrize, tournament.Location, tournament.StartDate, tournament.EndDate);
            }

        }
    }
}
