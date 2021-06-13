namespace JTSystem.Application.Tournaments.Comands.Categories.Create
{
    using Common;
    using JTSystem.Application.Tournaments.Comands.Create;
    using JTSystem.Domain.Common.Models;
    using JTSystem.Domain.Tournaments.Models.Tournaments;
    using JTSystem.Domain.Tournaments.Repositories;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class CreateCategoryCommand : CategoryCommand<CreateCategoryCommand>, IRequest<CreateCategoryOutputModel>
    {
        public int TournamentId { get; set; }

        public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, CreateCategoryOutputModel>
        {
            private readonly ITournamentDomainRepository tournamentDomainRepository;

            public CreateCategoryCommandHandler(
                ITournamentDomainRepository tournamentDomainRepository)
            {
                this.tournamentDomainRepository = tournamentDomainRepository;
            }

            public async Task<CreateCategoryOutputModel> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
            {
                var tournament = await this.tournamentDomainRepository.Find(request.TournamentId, cancellationToken);

                var category = new Category(request.Name, Enumeration.FromValue<Gender>(request.Gender));

                tournament.AddCategory(category);

                await this.tournamentDomainRepository.Save(tournament, cancellationToken);

                return new CreateCategoryOutputModel(category.Id);
            }
        }
    }
}
