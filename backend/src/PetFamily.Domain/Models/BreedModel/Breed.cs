using PetFamily.Domain.Models.PetModel;
using PetFamily.Domain.Models.Shared;

namespace PetFamily.Domain.Models.BreedModel
{
    public sealed class Breed : Entity<BreedId>
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

        public static Result<Breed> Create(BreedId id,
            string name,
            string description)
        {
            if (id == null)
                return "Id can not be empty";

            if (string.IsNullOrWhiteSpace(name))
                return "Name can not be empty";

            if (string.IsNullOrWhiteSpace(description))
                return "Description can not be empty";

            if (name.Length > Constants.MAX_LOW_TEXT_LENGHT)
                return "Name max lenghst: " + Convert.ToString(Constants.MAX_LOW_TEXT_LENGHT);

            if (description.Length > Constants.MAX_HIGH_TEXT_LENGHT)
                return "Description max lenghst: " + Convert.ToString(Constants.MAX_HIGH_TEXT_LENGHT);

            return new Breed(id, name, description);
        }
    }
}
