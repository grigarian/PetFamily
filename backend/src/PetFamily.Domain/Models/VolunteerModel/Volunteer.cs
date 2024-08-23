using PetFamily.Domain.Models.PetModel;
using PetFamily.Domain.Models.Shared;
using PetFamily.Domain.Models.VolunteerModel;

namespace PetFamily.Domain.Models.Volunteer
{
    public class Volunteer : Entity<VolunteerId>
    {
        private Volunteer(VolunteerId id) : base(id)
        {
            
        }

        private Volunteer(VolunteerId volunteerId, string name, string description, int workexp, int countPetFoundHome, int countPetLookiungForHome, int countPetBeingTreated, string phoneNumber,
            ListSocialNetworks socialNetworks, ListRequisites requisites, List<Pet> pets) 
            : base(volunteerId)
        {
            Name = name;
            Description = description;
            WorkExpirience = workexp;
            CountPetFoundHome = countPetFoundHome;
            CountPetLookingForHome = countPetLookiungForHome;
            CountPetBeingTreated = countPetBeingTreated;
            PhoneNumber = phoneNumber;
            SocialNetworks = socialNetworks;
            Requisites = requisites;
            Pets = pets;
        }


        public string Name { get; private set; }

        public string Description { get; private set; }

        public int WorkExpirience { get; private set; }

        public int CountPetFoundHome { get; private set; }

        public int CountPetLookingForHome { get; private set; }

        public int CountPetBeingTreated { get; private set; }

        public string PhoneNumber { get; private set; }

        public ListSocialNetworks SocialNetworks { get; private set; }

        public ListRequisites Requisites { get; private set; }

        public List<Pet> Pets { get; private set; }
    }
}
