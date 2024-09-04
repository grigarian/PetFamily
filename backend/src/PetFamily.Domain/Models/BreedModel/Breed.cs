using CSharpFunctionalExtensions;
using CSharpFunctionalExtensions.ValueTasks;
using PetFamily.Domain.Models.Shared;

namespace PetFamily.Domain.Models.BreedModel
{
    public sealed class Breed : Shared.Entity<BreedId>
    {
        private Breed(BreedId id) : base(id) { }

        private Breed(
            BreedId id,
            string name,
            string description)
            : base(id)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public static Result<Breed, Error> Create(BreedId id,
            string name,
            string description)
        {
            if (id == null)
                return Errors.General.ValueIsInvalid("id");

            if (string.IsNullOrWhiteSpace(name))
                return Errors.General.ValueIsInvalid("name");

            if (string.IsNullOrWhiteSpace(description))
                return Errors.General.ValueIsInvalid("description");

            if (name.Length > Constants.MAX_LOW_TEXT_LENGHT)
                return Errors.General.ValueIsRequired("name");

            if (description.Length > Constants.MAX_HIGH_TEXT_LENGHT)
                return Errors.General.ValueIsRequired("description");

            return new Breed(id, name, description);
        }
    }
}
