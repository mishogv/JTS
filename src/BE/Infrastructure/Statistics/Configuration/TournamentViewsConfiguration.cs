namespace JTSystem.Infrastructure.Statistics.Configuration
{
    using JTSystem.Domain.Statistics.Models;
    using JTSystem.Domain.Tournaments.Models.Tournaments;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TournamentViewsConfiguration : IEntityTypeConfiguration<TournamentView>
    {
        public void Configure(EntityTypeBuilder<TournamentView> builder)
        {
            builder
                .HasKey(t => t.Id);

            builder
                .Property(t => t.When)
                .IsRequired();

            builder
                .HasOne<Tournament>()
                .WithMany()
                .HasForeignKey(j => j.TournamentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
