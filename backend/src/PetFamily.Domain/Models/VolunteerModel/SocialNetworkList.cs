using PetFamily.Domain.Models.Volunteer;

namespace PetFamily.Domain.Models.VolunteerModel
{
    public record SocialNetworkList
    {
        private SocialNetworkList() {}

        private SocialNetworkList(ICollection<SocialNetwork> socialNetworks) => SocialNetworks = socialNetworks.ToList();

        public IReadOnlyList<SocialNetwork> SocialNetworks { get; }
    }
}
