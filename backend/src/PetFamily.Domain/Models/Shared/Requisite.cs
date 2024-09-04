using CSharpFunctionalExtensions;

namespace PetFamily.Domain.Models.Shared
{
    public record Requisite
    {
        public string Name { get; }

        public string Description { get; }

        private Requisite(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public static Result<Requisite, Error> Create (string name, string description)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length > Constants.MAX_LOW_TEXT_LENGHT)
                return Errors.General.ValueIsInvalid("name");

            if (string.IsNullOrWhiteSpace(description) || description.Length > Constants.MAX_HIGH_TEXT_LENGHT)
                return Errors.General.ValueIsInvalid("description");

            return new Requisite(name, description);
        }
    }
}
