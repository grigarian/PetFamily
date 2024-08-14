namespace PetFamily.Domain.Models
{
    public class Volunteer
    {
        public Guid ID { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public int WorkExpirience { get; private set; }

        public int CountPetFoundHome { get; private set; }

        public int CountPetLookingForHome { get; private set; }

        public int CountPetBeingTreated { get; private set; }

        public string PhoneNumber { get; private set; }

        public List<SocialNetwork> SocialNetworks { get; private set; }

        public List<Requisite> Requisites { get; private set;}

        public List<Pet> Pets { get; private set; }
    }
}
