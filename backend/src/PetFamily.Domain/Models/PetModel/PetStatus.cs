using PetFamily.Domain.Enums;

namespace PetFamily.Domain.Models.PetModel
{
    public record PetStatus
    {
        public PetStatusEnum Value { get; }
    }

}
