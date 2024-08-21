using PetFamily.Domain.Models.Volunteer;

namespace PetFamily.Domain.Models.VolunteerModel
{
    public record ListSocialNetworks
    {
        public List<SocialNetwork> SocialNetworks { get; private set; }
    }
}
