namespace JTSystem.Domain.Tournaments.Repositories
{
    using Common;
    using Models.Tournaments;
    using System.Threading;
    using System.Threading.Tasks;

    public interface ITournamentDomainRepository : IDomainRepository<Tournament>
    {
        Task<Tournament> Find(int id, CancellationToken cancellationToken = default);

        Task<Category> FindCategory(int id, CancellationToken cancellationToken = default);

        Task<Judoka> FindJudoka(int id, CancellationToken cancellationToken = default);

        Task<bool> Delete(int id, CancellationToken cancellationToken = default);

        Task<bool> DeleteCategory(int id, CancellationToken cancellationToken = default);

        Task<bool> DeleteJudoka(int id, CancellationToken cancellationToken = default);

        Task<Category> EditCategory(Category category, CancellationToken cancellationToken = default);

        Task<Judoka> EditJudoka(Judoka judoka, CancellationToken cancellationToken = default);
    }
}
