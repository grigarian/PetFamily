using PetFamily.Domain.Models.PetModel;
using PetFamily.Domain.Models.Shared;
using PetFamily.Domain.Models.VolunteerModel;

namespace PetFamily.Domain.Models.Volunteer
{
    public class Volunteer
    {
        private Volunteer()
        {
            
        }

        public Guid ID { get; private set; }

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
