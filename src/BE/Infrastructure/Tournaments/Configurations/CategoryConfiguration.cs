namespace JTSystem.Infrastructure.Tournaments.Configurations
{
    using JTSystem.Domain.Tournaments.Models.Tournaments;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .HasKey(c => c.Id);

            builder
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            //builder
            //    .HasOne(c => c.Gender)
            //    .WithMany()
            //    .HasForeignKey("CategoryId")
            //    .OnDelete(DeleteBehavior.Restrict);

            builder
               .OwnsOne(c => c.Gender, g =>
               {
                   g.Property(g => g.Value);
               });
        }
    }
}
