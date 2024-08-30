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
        
    }
}
