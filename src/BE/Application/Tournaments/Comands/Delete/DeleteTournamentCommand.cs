namespace JTSystem.Application.Tournaments.Comands.Delete
{
    using JTSystem.Application.Common;
    using JTSystem.Domain.Tournaments.Repositories;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class DeleteTournamentCommand : EntityCommand<int>, IRequest<Result>
    {
        public class DeleteTournamentCommandHandler : IRequestHandler<DeleteTournamentCommand, Result>
        {
            private readonly ITournamentDomainRepository tournamentDomainRepository;

            public DeleteTournamentCommandHandler(
                ITournamentDomainRepository tournamentDomainRepository)
            {
                this.tournamentDomainRepository = tournamentDomainRepository;
            }

            public async Task<Result> Handle(DeleteTournamentCommand request, CancellationToken cancellationToken)
                => await this.tournamentDomainRepository.Delete(request.Id, cancellationToken);
        }
    }
}
