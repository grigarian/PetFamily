using PetFamily.Domain.Models.Volunteer;

namespace PetFamily.Domain.Models.VolunteerModel
{
    public record SocialNetworks
    {
        public List<SocialNetwork> SocialNetwork { get; private set; }
    }
}
