namespace JTSystem.Infrastructure.Statistics.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using JTSystem.Domain.Statistics.Models;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class StatisticsConfiguration : IEntityTypeConfiguration<Statistics>
    {
        public void Configure(EntityTypeBuilder<Statistics> builder)
        {
            builder
                .Property<int>("Id");

            builder
                .HasKey("Id");

            builder
                .HasMany(j => j.JudokaViews)
                .WithOne()
                .Metadata
                .PrincipalToDependent
                .SetField("judokaViews");
        }
    }
}
