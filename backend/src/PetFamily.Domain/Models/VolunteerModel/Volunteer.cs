using PetFamily.Domain.Enums;
using PetFamily.Domain.Models.PetModel;
using PetFamily.Domain.Models.Shared;

namespace PetFamily.Domain.Models.VolunteerModel
{
    public class Volunteer : Entity<VolunteerId>
    {
        private readonly List<Pet> _pets = [];
        private Volunteer(VolunteerId id) : base(id)
        {

        }

        public Volunteer(
            VolunteerId volunteerId,
            string name,
            string description,
            int workexp,
            string phoneNumber,
            SocialNetworkList socialNetworks,
            RequisiteList requisites) 
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

        public SocialNetworkList SocialNetworks { get; private set; }

        public RequisiteList Requisites { get; private set; }

        public IReadOnlyList<Pet> Pets  => _pets;

        public int GetCountPetFoundHome() => _pets.Count(p => p.PetStatus == PetStatusEnum.FoundHome);

        public int CountPetLookingForHome() => _pets.Count(p => p.PetStatus == PetStatusEnum.LookingForHome);

        public int CountPetLookingForHelp() => _pets.Count(p => p.PetStatus == PetStatusEnum.LookingForHelp);

        public static Result<Volunteer> Create (VolunteerId volunteerId,
            string name,
            string description,
            int workexp,
            string phoneNumber,
            SocialNetworkList socialNetworks,
            RequisiteList requisites)
        {
            if (volunteerId == null)
                return "Id can not be empty";

            if (string.IsNullOrEmpty(name) || name.Length > Constants.MAX_LOW_TEXT_LENGHT)
                return "Name can not be empty or longer " + Constants.MAX_LOW_TEXT_LENGHT + "symbols";

            if (string.IsNullOrEmpty(description) || description.Length > Constants.MAX_HIGH_TEXT_LENGHT)
                return "Description can not be empty or longer " + Constants.MAX_HIGH_TEXT_LENGHT + "symbols";

            if (workexp < 0)
                return "Work expiriense cannot be less then 0";

            if (string.IsNullOrEmpty(phoneNumber) || phoneNumber.Length > Constants.MAX_PHONENUMBER_LENGHT)
                return "Phone number can not be empty or longer " + Constants.MAX_PHONENUMBER_LENGHT + "symbols";

            return new Volunteer(
                volunteerId,
                name,
                description,
                workexp,
                phoneNumber,
                socialNetworks,
                requisites);
        }
    }
}
