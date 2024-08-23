using PetFamily.Domain.Models.PetModel;

namespace PetFamily.Domain.Models.VolunteerModel
{
    public record ListPet
    {
        public List<Pet> Pets { get; private set; }
    }
}
