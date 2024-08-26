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

            builder.Property(v => v.CountPetFoundHome)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_INT_LENGHT);

            builder.Property(v => v.CountPetLookingForHome)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_INT_LENGHT);

            builder.Property(v => v.CountPetBeingTreated)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_INT_LENGHT);

            builder.Property(v => v.PhoneNumber)
                .IsRequired()
                .HasMaxLength(Constants.MAX_PHONENUMBER_LENGHT);

            builder.OwnsOne(v => v.SocialNetworks, sb =>
            {
                sb.ToJson();

                sb.OwnsMany(s => s.SocialNetworks, snb =>
                {
                    snb.Property(sn => sn.Name)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_LOW_TEXT_LENGHT);

                    snb.Property(sn => sn.Link)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGHT);
                });
            });

            builder.OwnsOne(v => v.Requisites, rb =>
            {
                rb.ToJson();

                rb.OwnsMany(r => r.Requisites, reb =>
                {
                    reb.Property(req => req.Name)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_LOW_TEXT_LENGHT);

                    reb.Property(req => req.Description)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGHT);
                });
            });

            builder.HasMany(v => v.Pets)
                .WithOne()
                .IsRequired()
                .HasForeignKey("volunteer_id");

        }
    }
}
