namespace JTSystem.Infrastructure.Statistics.Configuration
{
    using JTSystem.Domain.Statistics.Models;
    using JTSystem.Domain.Tournaments.Models.Tournaments;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class JudokaViewsConfiguration : IEntityTypeConfiguration<JudokaView>
    {
        public void Configure(EntityTypeBuilder<JudokaView> builder)
        {
            builder
                .HasKey(j => j.Id);

            builder
                .Property(j => j.When)
                .IsRequired();

            builder
                .HasOne<Judoka>()
                .WithMany()
                .HasForeignKey(j => j.JudokaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
