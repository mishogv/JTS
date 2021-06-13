namespace JTSystem.Infrastructure.Tournaments.Configurations
{
    using JTSystem.Domain.Tournaments.Models.Tournaments;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class JudokaConfiguration : IEntityTypeConfiguration<Judoka>
    {
        public void Configure(EntityTypeBuilder<Judoka> builder)
        {
            builder
                .HasKey(j => j.Id);

            builder
                .Property(j => j.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(j => j.Wins)
                .IsRequired();

            builder
                .Property(j => j.Loses)
                .IsRequired();

            builder
                .HasOne(j => j.Category)
                .WithMany()
                .HasForeignKey("CategoryId")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
