using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetFamily.Domain.Models.BreedModel;
using PetFamily.Domain.Models.Shared;

namespace PetFamily.Infrastructure.Configuration
{
    public class BreedConfiguration : IEntityTypeConfiguration<Breed>
    {
        public void Configure(EntityTypeBuilder<Breed> builder)
        {
            builder.ToTable("breed");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.Id)
                .HasConversion(
                id => id.Value,
                value => BreedId.Create(value));

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGHT);

            builder.Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGHT);
        }
    }
}
