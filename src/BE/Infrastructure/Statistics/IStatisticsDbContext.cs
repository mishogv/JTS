namespace JTSystem.Infrastructure.Statistics
{
    using JTSystem.Infrastructure.Common.Persistence;
    using Microsoft.EntityFrameworkCore;
    using JTSystem.Domain.Statistics.Models;

    internal interface IStatisticsDbContext : IDbContext
    {
        DbSet<Statistics> Statistics { get; }

        DbSet<JudokaView> JudokaViews { get; }

        DbSet<TournamentView> TournamentViews { get; }
    }
}
