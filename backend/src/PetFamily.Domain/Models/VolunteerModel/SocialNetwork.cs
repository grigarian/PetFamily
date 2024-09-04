using CSharpFunctionalExtensions;
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

        public static Result<SocialNetwork, Error> Create(string name, string link)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length > Constants.MAX_LOW_TEXT_LENGHT)
                return Errors.General.ValueIsInvalid("name");

            if (string.IsNullOrWhiteSpace(link) || link.Length > Constants.MAX_HIGH_TEXT_LENGHT)
                return Errors.General.ValueIsInvalid("link");

            return new SocialNetwork(name, link);
        }
    }
}
