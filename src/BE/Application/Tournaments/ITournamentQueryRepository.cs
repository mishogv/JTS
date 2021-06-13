namespace JTSystem.Application.Tournaments
{
    using Common.Contracts;
    using Domain.Tournaments.Models.Tournaments;
    using JTSystem.Application.Tournaments.Queries.Common;
    using JTSystem.Application.Tournaments.Queries.Details;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public interface ITournamentQueryRepository : IQueryRepository<Tournament>
    {
        public Task<TournamentDetailsOutputModel> GetTournamentDetails(int id, CancellationToken cancellationToken);

        public Task<JudokaOutputModel> GetJudokaDetails(int id, CancellationToken cancellationToken);

        public Task<IEnumerable<TournamentOutputModel>> AllTournaments(CancellationToken cancellationToken);

        public Task<IEnumerable<JudokaOutputModel>> AllJudokas(CancellationToken cancellationToken);

        public Task<IEnumerable<JudokaOutputModel>> GetJudokasByTournament(int tournamentId, CancellationToken cancellationToken);
    }
}
