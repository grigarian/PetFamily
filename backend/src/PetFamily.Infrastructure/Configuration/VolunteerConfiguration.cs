using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetFamily.Domain.Models.Shared;
using PetFamily.Domain.Models.Volunteer;
using PetFamily.Domain.Models.VolunteerModel;

namespace PetFamily.Infrastructure.Configuration
{
    public class VolunteerConfiguration : IEntityTypeConfiguration<Volunteer>
    {
        public void Configure(EntityTypeBuilder<Volunteer> builder)
        {
            builder.ToTable("volunteers"); 

            builder.HasKey(v => v.Id);

            builder.Property(p => p.Id)
                .HasConversion(
                id => id.Value,
                value => VolunteerId.Create(value));

            builder.Property(v => v.Name)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGHT);

            builder.Property (v => v.Description)
                .IsRequired()
                .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGHT);

            builder.Property(v => v.WorkExpirience)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_INT_LENGHT);

            builder.Property(v => v.PhoneNumber)
                .IsRequired()
                .HasMaxLength(Constants.MAX_PHONENUMBER_LENGHT);

            builder.OwnsOne(v => v.SocialNetworks, snlb =>
            {
                snlb.ToJson("social_networks");
                snlb.OwnsMany(sn => sn.SocialNetworks, snb =>
                {
                    snb.Property(sn => sn.Name)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_LOW_TEXT_LENGHT)
                    .HasColumnName("name");

                    snb.Property(sn => sn.Link)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGHT)
                    .HasColumnName("link");
                });
                
            });

            builder.OwnsOne(v => v.Requisites, rlb =>
            {
                rlb.ToJson("requisites");
                rlb.OwnsMany(r => r.Requisites, rb =>
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

            builder.HasMany(v => v.Pets)
                .WithOne()
                .IsRequired()
                .HasForeignKey("volunteer_id");

        }
    }
}
