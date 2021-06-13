namespace JTSystem.Application.Tournaments.Comands.Categories.Edit
{
    using JTSystem.Application.Tournaments.Comands.Categories.Common;
    using JTSystem.Domain.Common.Models;
    using JTSystem.Domain.Tournaments.Factories.Tournaments;
    using JTSystem.Domain.Tournaments.Models.Tournaments;
    using JTSystem.Domain.Tournaments.Repositories;
    using MediatR;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    public class EditCategoryCommand : CategoryCommand<EditCategoryCommand>, IRequest<EditCategoryOutputModel>
    {
        public class EditCategoryCommandHandler : IRequestHandler<EditCategoryCommand, EditCategoryOutputModel>
        {
            private readonly ITournamentDomainRepository tournamentDomainRepository;

            public EditCategoryCommandHandler(
                ITournamentDomainRepository tournamentDomainRepository)
            {
                this.tournamentDomainRepository = tournamentDomainRepository;
            }

            public async Task<EditCategoryOutputModel> Handle(EditCategoryCommand request, CancellationToken cancellationToken)
            {
                var category = await this.tournamentDomainRepository.FindCategory(request.Id);

                category.UpdateName(request.Name);
                category.UpdateGender(Enumeration.FromValue<Gender>(request.Gender));

                await this.tournamentDomainRepository.EditCategory(category, cancellationToken);

                return new EditCategoryOutputModel(category.Id, category.Name, category.Gender);
            }

        }
    }
}
