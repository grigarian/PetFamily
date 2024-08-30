using PetFamily.Domain.Models.BreedModel;
using PetFamily.Domain.Models.Shared;
using PetFamily.Domain.Models.SpeciesModel;
using System;

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

        public static Result<Type> Create(
            Guid breedId,
            SpeciesId speciesId)
        {
            return new Type(breedId, speciesId);
        }
    }
}
