using PetFamily.Domain.Enums;

namespace PetFamily.Domain.Models
{
    public class Pet
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public string Type { get; private set; }

        public string Description { get; private set; }

        public string Breed { get; private set; }

        public string Color { get; private set; }

        public string HealthInfo { get; private set; }

        public string Address { get; private set; }

        public string Weight { get; private set; }

        public string Hight { get; private set; }

        public string PhoneNumber { get; private set; }

        public bool IsCastrated { get; private set; }

        public DateOnly Birthday { get; private set; }

        public bool isVaccinated { get; private set; }

        public PetStatus PetStatus { get; private set; }

        public ICollection<Requisite> Requisites { get; private set;}

        public DateTime CreationDate { get; private set; }
    }
}
