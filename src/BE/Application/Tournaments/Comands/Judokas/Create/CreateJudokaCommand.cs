namespace JTSystem.Application.Tournaments.Comands.Judokas.Create
{
    using Common;
    using JTSystem.Application.Common;
    using JTSystem.Domain.Tournaments.Models.Tournaments;
    using JTSystem.Domain.Tournaments.Repositories;
    using MediatR;
    using System;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    public class CreateJudokaCommand : JudokaCommand<CreateJudokaCommand>, IRequest<CreateJudokaOutputModel>
    {
        public int TournamentId { get; set; }

        public int Wins { get; set; }

        public int Loses { get; set; }

        public class CreateJudokaCommandHandler : IRequestHandler<CreateJudokaCommand, CreateJudokaOutputModel>
        {
            private readonly ITournamentDomainRepository tournamentDomainRepository;

            public CreateJudokaCommandHandler(
                ITournamentDomainRepository tournamentDomainRepository)
            {
                this.tournamentDomainRepository = tournamentDomainRepository;
            }

            public async Task<CreateJudokaOutputModel> Handle(CreateJudokaCommand request, CancellationToken cancellationToken)
            {
                var tournament = await this.tournamentDomainRepository.Find(request.TournamentId, cancellationToken);
                var category = tournament.Categories.FirstOrDefault(x => x.Id == request.CategoryId);
                if (tournament == null || category == null)
                {
                    throw new InvalidOperationException("Category or tournament are not created");
                }

                var judoka = new Judoka(request.Name, category, request.Wins, request.Loses);

                tournament.AddJudoka(judoka);

                await this.tournamentDomainRepository.Save(tournament, cancellationToken);

                return new CreateJudokaOutputModel(judoka.Id);
            }
        }
    }
}
