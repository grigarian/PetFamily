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

            builder.ComplexProperty(p => p.Address, ab =>
            {
                ab.Property(a => a.City)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGHT)
                .HasColumnName("city");

                ab.Property(a => a.Street)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGHT)
                .HasColumnName("street");

                ab.Property(a => a.PostalCode)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGHT)
                .HasColumnName("postal_code");

                ab.Property(a => a.HouseNumber)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGHT)
                .HasColumnName("house_number");

                ab.Property(a => a.ApartNumber)
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGHT)
                .HasColumnName("apartament_number");
            });
                

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

            builder.Property(p => p.IsVaccinated)
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


            builder.OwnsOne(p => p.Requisites, rlb =>
            {
                rlb.ToJson();
                rlb.OwnsMany(r => r.Requisite, rb =>
                {
                    rb.Property(r => r.Name)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_LOW_TEXT_LENGHT)
                    .HasColumnName("name");

                    rb.Property(r => r.Description)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGHT)
                    .HasColumnName("description");

                });
            });


            builder.OwnsOne(p => p.PetPhotos, plb =>
            {
                plb.ToJson();
                plb.OwnsMany(pp => pp.PetPhoto, ppb =>
                {
                    ppb.Property(pp => pp.Path)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGHT)
                    .HasColumnName("path");

                    ppb.Property(pp => pp.IsMainPhoto)
                    .IsRequired()
                    .HasColumnName("is_main_photo");
                });
                
            });


        }
    }
}
