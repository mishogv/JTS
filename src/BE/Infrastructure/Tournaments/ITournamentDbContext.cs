namespace JTSystem.Infrastructure.Tournaments
{
    using Common.Persistence;
    using JTSystem.Domain.Tournaments.Models.Tournaments;
    using Microsoft.EntityFrameworkCore;

    internal interface ITournamentDbContext : IDbContext
    {
        DbSet<Tournament> Tournaments { get; }

        DbSet<Category> Categories { get; }

        DbSet<Judoka> Judokas { get; }
    }
}
