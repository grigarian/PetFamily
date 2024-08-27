using PetFamily.Domain.Enums;
using PetFamily.Domain.Models.PetModel;
using PetFamily.Domain.Models.Shared;
using PetFamily.Domain.Models.VolunteerModel;

namespace PetFamily.Domain.Models.Volunteer
{
    public class Volunteer : Entity<VolunteerId>
    {
        private readonly List<Pet> _pets = [];
        private Volunteer(VolunteerId id) : base(id)
        {
            
        }

        private Volunteer(
            VolunteerId volunteerId,
            string name,
            string description,
            int workexp,
            string phoneNumber,
            SocialNetworks socialNetworks,
            Requisites requisites) 
            : base(volunteerId)
        {
            Name = name;
            Description = description;
            WorkExpirience = workexp;
            PhoneNumber = phoneNumber;
            SocialNetworks = socialNetworks;
            Requisites = requisites;
        }


        public string Name { get; private set; }

        public string Description { get; private set; }

        public int WorkExpirience { get; private set; }

        public string PhoneNumber { get; private set; }

        public SocialNetworks SocialNetworks { get; private set; }

        public Requisites Requisites { get; private set; }

        public IReadOnlyList<Pet> Pets  => _pets;

        public int GetCountPetFoundHome() => _pets.Count(p => p.PetStatus == PetStatusEnum.FoundHome);

        public int CountPetLookingForHome() => _pets.Count(p => p.PetStatus == PetStatusEnum.LookingForHome);

        public int CountPetLookingForHelp() => _pets.Count(p => p.PetStatus == PetStatusEnum.LookingForHelp);
    }
}
