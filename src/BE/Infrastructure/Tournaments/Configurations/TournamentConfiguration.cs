namespace JTSystem.Infrastructure.Tournaments.Configurations
{
    using JTSystem.Domain.Tournaments.Models.Tournaments;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class TournamentConfiguration : IEntityTypeConfiguration<Tournament>
    {
        public void Configure(EntityTypeBuilder<Tournament> builder)
        {
            builder
                .HasKey(t => t.Id);

            builder
                .Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(t => t.WinPrize)
                .IsRequired();

            builder
                .Property(t => t.Location)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(t => t.StartDate)
                .IsRequired();

            builder
                .Property(t => t.EndDate)
                .IsRequired();

            builder
                .HasMany(t => t.Categories)
                .WithOne()
                .HasForeignKey("TournamentId")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(t => t.Judokas)
                .WithOne()
                .HasForeignKey("TournamentId")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
