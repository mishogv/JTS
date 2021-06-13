namespace JTSystem.Application.Tournaments.Comands.Judokas.Edit
{
    using Common;
    using JTSystem.Domain.Tournaments.Repositories;
    using MediatR;
    using System;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    public class EditJudokaCommand : JudokaCommand<EditJudokaCommand>, IRequest<EditJudokaOutputModel>
    {
        public int TournamentId { get; set; }

        public int Wins { get; set; }

        public int Loses { get; set; }

        public class EditJudokaCommandHandler : IRequestHandler<EditJudokaCommand, EditJudokaOutputModel>
        {
            private readonly ITournamentDomainRepository tournamentDomainRepository;

            public EditJudokaCommandHandler(
                ITournamentDomainRepository tournamentDomainRepository)
            {
                this.tournamentDomainRepository = tournamentDomainRepository;
            }

            public async Task<EditJudokaOutputModel> Handle(EditJudokaCommand request, CancellationToken cancellationToken)
            {
                var tournament = await this.tournamentDomainRepository.Find(request.TournamentId, cancellationToken);
                var category = tournament.Categories.FirstOrDefault(x => x.Id == request.CategoryId);

                if (tournament == null || category == null)
                {
                    throw new InvalidOperationException("Category or tournament are not created");
                }

                var judoka = await this.tournamentDomainRepository.FindJudoka(request.Id);
                judoka.UpdateJudoka(request.Name, category, request.Wins, request.Loses);

                await this.tournamentDomainRepository.EditJudoka(judoka, cancellationToken);

                return new EditJudokaOutputModel(judoka.Id, judoka.Name, judoka.Category);
            }

        }
    }
}
