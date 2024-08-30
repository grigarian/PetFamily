using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetFamily.Domain.Models.Shared;
using PetFamily.Domain.Models.SpeciesModel;

namespace PetFamily.Infrastructure.Configuration
{
    public class SpeciesConfiguration : IEntityTypeConfiguration<Species>
    {
        public void Configure(EntityTypeBuilder<Species> builder)
        {
            builder.ToTable("species");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id)
                .HasConversion(
                id => id.Value,
                value => SpeciesId.Create(value));

            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGHT);

            builder.Property(s => s.Description)
                .IsRequired()
                .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGHT);

            builder.HasMany(s => s.Breeds)
                .WithOne()
                .IsRequired()
                .HasForeignKey("species_id");
        }

    }
}
