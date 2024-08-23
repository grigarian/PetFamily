using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetFamily.Domain.Models.PetModel;
using PetFamily.Domain.Models.Shared;

namespace PetFamily.Infrastructure.Configuration
{
    public class PetConfiguration: IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable("pets");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasConversion(
                id => id.Value,
                value => PetId.Create(value));

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGHT);

            builder.Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGHT);

            builder.Property(p => p.Breed)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGHT);

            builder.Property(p => p.Color)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGHT);

            builder.Property(p => p.HealthInfo)
                .IsRequired()
                .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGHT);

            builder.Property(p => p.Address)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGHT);

            builder.Property(p => p.Hight)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGHT);

            builder.Property(p => p.Weight)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGHT);

            builder.Property(p => p.PhoneNumber)
                .IsRequired()
                .HasMaxLength(Constants.MAX_PHONENUMBER_LENGHT);

            builder.Property(p => p.IsCastrated)
                .IsRequired();

            builder.Property(p => p.isVaccinated)
                .IsRequired();

            builder.Property(p => p.Birthday)
                .IsRequired()
                .HasMaxLength(Constants.MAX_DATE_LENGHT);

            builder.Property(p => p.CreationDate)
                .IsRequired()
                .HasMaxLength(Constants.MAX_DATE_LENGHT);

            builder.OwnsOne(p => p.PetStatus, pb =>
            {
                builder.OwnsOne(ps => ps.PetStatus, pse =>
                {
                    pse.Property(v => v.Value)
                    .IsRequired()
                    .HasConversion<string>();
                });
            });
                

            builder.OwnsOne(r => r.Requisites, rb =>
            {
                rb.ToJson();

                rb.OwnsMany(re => re.Requisites, reb =>
                {
                    reb.Property(req => req.Name)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_LOW_TEXT_LENGHT);

                    reb.Property(req => req.Description)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGHT);
                });
            });

            
            builder.HasMany(p => p.PetPhotos)
                .WithOne()
                .IsRequired()
                .HasForeignKey("volunteer_id");
                

        }
    }
}
