using CSharpFunctionalExtensions;
using PetFamily.Domain.Models.Shared;
using PetFamily.Domain.Models.SpeciesModel;

namespace PetFamily.Domain.Models.PetModel
{
    public record Type
    {
        private Type() { }

        private Type(
            Guid breedId, 
            SpeciesId speciesId)
        {
            BreedId = breedId;
            SpeciesId = speciesId;
        }

        public Guid BreedId { get; }

        public SpeciesId SpeciesId { get; }

        public static Result<Type, Error> Create
            (
                Guid breedId,
                SpeciesId speciesId
            )
        {
            if (breedId == Guid.Empty)
                return Errors.General.ValueIsInvalid("breedId");

            return new Type(breedId, speciesId);
        }
    }
}
