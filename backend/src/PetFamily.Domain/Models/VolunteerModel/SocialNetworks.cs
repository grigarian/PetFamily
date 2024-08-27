using PetFamily.Domain.Models.Volunteer;

namespace PetFamily.Domain.Models.VolunteerModel
{
    public record SocialNetworks
    {
        public IReadOnlyList<SocialNetwork> SocialNetwork { get; private set; }
    }
}
