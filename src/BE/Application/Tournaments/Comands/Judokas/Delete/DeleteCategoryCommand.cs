namespace JTSystem.Application.Tournaments.Comands.Categories.Delete
{
    using JTSystem.Application.Common;
    using JTSystem.Domain.Tournaments.Repositories;
    using MediatR;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    public class DeleteJudokaCommand : EntityCommand<int>, IRequest<Result>
    {
        public int TournamentId { get; set; }

        public class DeleteJudokaCommandHandler : IRequestHandler<DeleteJudokaCommand, Result>
        {
            private readonly ITournamentDomainRepository tournamentDomainRepository;

            public DeleteJudokaCommandHandler(
                ITournamentDomainRepository tournamentDomainRepository)
            {
                this.tournamentDomainRepository = tournamentDomainRepository;
            }

            public async Task<Result> Handle(DeleteJudokaCommand request, CancellationToken cancellationToken)
            {
                // TODO: Validate
                var tournament = await this.tournamentDomainRepository.Find(request.TournamentId, cancellationToken);
                var judoka = tournament.Judokas.FirstOrDefault(c => c.Id == request.Id);
                tournament.RemoveJudoka(judoka);

                await this.tournamentDomainRepository.DeleteJudoka(judoka.Id, cancellationToken);
                await this.tournamentDomainRepository.Save(tournament);

                return Result.Success;
            }
        }
    }
}
