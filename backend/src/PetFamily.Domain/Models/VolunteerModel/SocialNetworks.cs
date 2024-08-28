using PetFamily.Domain.Models.Volunteer;

namespace PetFamily.Domain.Models.VolunteerModel
{
    public record SocialNetworks
    {
        private SocialNetworks() {}

        private SocialNetworks(ICollection<SocialNetwork> socialNetworks) => SocialNetwork = socialNetworks.ToList();

        public IReadOnlyList<SocialNetwork> SocialNetwork { get; }

        public static SocialNetworks Create(ICollection<SocialNetwork> socialNetworks) => new(socialNetworks);
    }
}
