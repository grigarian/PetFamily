using PetFamily.Domain.Models.Shared;
using PetFamily.Domain.Models.Volunteer;

namespace PetFamily.Domain.Models.VolunteerModel
{
    public record SocialNetworkList
    {
        private SocialNetworkList() {}

        private SocialNetworkList(IEnumerable<SocialNetwork> socialNetworks) => SocialNetworks = socialNetworks.ToList();

        public IReadOnlyList<SocialNetwork> SocialNetworks { get; }

        public static Result<SocialNetworkList> Create (IEnumerable<SocialNetwork> socialNetworks)
        {
            return new SocialNetworkList (socialNetworks);
        }
    }
}
