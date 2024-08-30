using PetFamily.Domain.Models.BreedModel;
using PetFamily.Domain.Models.Shared;

namespace PetFamily.Domain.Models.SpeciesModel
{
    public class Species : Entity<SpeciesId>
    {
        private Species(SpeciesId id) : base(id) { }

        private Species(
            SpeciesId id,
            string name,
            string description)
            : base(id)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public IReadOnlyList<Breed> Breeds { get; private set; }

    }
}
