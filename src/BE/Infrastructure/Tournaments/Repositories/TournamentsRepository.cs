namespace JTSystem.Infrastructure.Tournaments.Repositories
{
    using JTSystem.Application.Tournaments;
    using JTSystem.Application.Tournaments.Queries.Common;
    using JTSystem.Application.Tournaments.Queries.Details;
    using JTSystem.Domain.Tournaments.Models.Tournaments;
    using JTSystem.Domain.Tournaments.Repositories;
    using JTSystem.Infrastructure.Common.Persistence;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    internal class TournamentsRepository : DataRepository<ITournamentDbContext, Tournament>,
        ITournamentQueryRepository,
        ITournamentDomainRepository
    {
        public TournamentsRepository(ITournamentDbContext db)
            : base(db)
        {
        }

        public async Task<IEnumerable<TournamentOutputModel>> AllTournaments(CancellationToken cancellationToken)
            => await this.Data.Tournaments
                .Select(x => new TournamentOutputModel(x.Id, x.Name, x.WinPrize, x.Location, x.StartDate, x.EndDate))
                .ToListAsync(cancellationToken);

        public async Task<Category> AddCategory(Tournament tournament, Category category, CancellationToken cancellationToken = default)
        {
            tournament.AddCategory(category);

            this.Data.Update(tournament);

            await this.Data.SaveChangesAsync(cancellationToken);

            return category;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken = default)
        {
            var tournament = await this.Data.Tournaments.FindAsync(id);

            if (tournament == null)
            {
                return false;
            }

            this.Data.Tournaments.Remove(tournament);

            return await this.Data.SaveChangesAsync(cancellationToken) > 0;
        }

        public async Task<Tournament> Find(int id, CancellationToken cancellationToken = default)
            => await this.Data.Tournaments
            .Include(x => x.Categories)
            .Include(x => x.Judokas)
            .FirstOrDefaultAsync(x => x.Id == id);

        public async Task<bool> DeleteCategory(int id, CancellationToken cancellationToken = default)
        {
            var category = await this.Data.Categories.FindAsync(id);
            this.Data.Categories.Remove(category);
            await this.Data.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<Category> EditCategory(Category category, CancellationToken cancellationToken = default)
        {
            this.Data.Update(category);
            await this.Data.SaveChangesAsync(cancellationToken);

            return category;
        }

        public async Task<Category> FindCategory(int id, CancellationToken cancellationToken = default)
            => await this.Data.Categories.FindAsync(id);

        public async Task<Judoka> FindJudoka(int id, CancellationToken cancellationToken = default)
            => await this.Data.Judokas.FindAsync(id);

        public async Task<Judoka> EditJudoka(Judoka judoka, CancellationToken cancellationToken = default)
        {
            this.Data.Update(judoka);
            await this.Data.SaveChangesAsync(cancellationToken);

            return judoka;
        }

        public async Task<bool> DeleteJudoka(int id, CancellationToken cancellationToken = default)
        {
            var judoka = await this.Data.Judokas.FindAsync(id);
            this.Data.Judokas.Remove(judoka);
            await this.Data.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<TournamentDetailsOutputModel> GetTournamentDetails(int id, CancellationToken cancellationToken)
        {
            var tournament = await this.All().FirstOrDefaultAsync(x => x.Id == id);
            tournament.RaiseTournamentViewedEvent();

            var judokas = tournament
                .Judokas
                .Select(x => 
                new JudokaOutputModel(
                    x.Name, 
                    new CategoryOutputModel(
                        x.Category.Name, 
                        x.Category.Gender), 
                    x.Wins, 
                    x.Loses))
                .ToList();

            var categories = tournament
                .Categories
                .Select(x => 
                new CategoryOutputModel(x.Name, x.Gender))
                .ToList();

            var tournamentOutputModel = new TournamentDetailsOutputModel(
                tournament.Id, 
                tournament.Name, 
                tournament.WinPrize, 
                tournament.Location, 
                tournament.StartDate, 
                tournament.EndDate, 
                categories, 
                judokas);

            await this.Data.HandleEvents();

            return tournamentOutputModel;
        }

        public async Task<JudokaOutputModel> GetJudokaDetails(int id, CancellationToken cancellationToken)
        {
            var judoka = await this.Data.Judokas.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == id);
            
            judoka.RaiseJudokaViewedEvent();
            await this.Data.HandleEvents();

            return new JudokaOutputModel(judoka.Name, new CategoryOutputModel(judoka.Category.Name, judoka.Category.Gender), judoka.Wins, judoka.Loses);
        }

        public async Task<IEnumerable<JudokaOutputModel>> AllJudokas(CancellationToken cancellationToken)
        {
            return await this.Data.Judokas.Include(x => x.Category).AsNoTracking().Select(x => new JudokaOutputModel(x.Name, new CategoryOutputModel(x.Category.Name, x.Category.Gender), x.Wins, x.Loses)).ToListAsync(cancellationToken);
        }

        public async Task<IEnumerable<JudokaOutputModel>> GetJudokasByTournament(int tournamentId, CancellationToken cancellationToken)
        {
            var tournament = await this.All().Include(x => x.Judokas).ThenInclude(x => x.Category).FirstOrDefaultAsync(x => x.Id == tournamentId);
            return tournament.Judokas.Select(x => new JudokaOutputModel(x.Name, new CategoryOutputModel(x.Category.Name, x.Category.Gender), x.Wins, x.Loses));
        }
    }
}
