using PetFamily.Domain.Models.Shared;

namespace PetFamily.Domain.Models.Volunteer
{
    public record SocialNetwork
    {
        public string Name { get; }

        public string Link { get; }

        private SocialNetwork(string name, string link)
        {
            Name = name;
            Link = link;
        }

        public static Result<SocialNetwork> Create(string name, string link)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length > Constants.MAX_LOW_TEXT_LENGHT)
                return "Name is invalid or empty";
            if (string.IsNullOrWhiteSpace(link) || link.Length > Constants.MAX_HIGH_TEXT_LENGHT)
                return "Link invalid or empty";

            return new SocialNetwork(name, link);
        }
    }
}
