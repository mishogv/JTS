namespace JTSystem.Application.Tournaments.Comands.Categories.Delete
{
    using JTSystem.Application.Common;
    using JTSystem.Domain.Tournaments.Repositories;
    using MediatR;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    public class DeleteCategoryCommand : EntityCommand<int>, IRequest<Result>
    {
        public int TournamentId { get; set; }

        public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, Result>
        {
            private readonly ITournamentDomainRepository tournamentDomainRepository;

            public DeleteCategoryCommandHandler(
                ITournamentDomainRepository tournamentDomainRepository)
            {
                this.tournamentDomainRepository = tournamentDomainRepository;
            }

            public async Task<Result> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
            {
                // TODO Validate
                var tournament = await this.tournamentDomainRepository.Find(request.TournamentId, cancellationToken);
                var category = tournament.Categories.FirstOrDefault(c => c.Id == request.Id);
                tournament.RemoveCategory(category);

                await this.tournamentDomainRepository.Save(tournament);
                await this.tournamentDomainRepository.DeleteCategory(category.Id, cancellationToken);

                return Result.Success;
            }
        }
    }
}
