using PetFamily.Domain.Models.Shared;

namespace PetFamily.Domain.Models.PetModel
{
    public sealed class Pet : Entity<PetId>
    {
        private Pet(PetId id) : base(id)
        {

        }

        private Pet(PetId petId, string name, string description) : base(petId)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; private set; }

        public string Type { get; private set; }

        public string Description { get; private set; }

        public string Breed { get; private set; }

        public string Color { get; private set; }

        public string HealthInfo { get; private set; }

        public string Address { get; private set; }

        public double Weight { get; private set; }

        public double Hight { get; private set; }

        public string PhoneNumber { get; private set; }

        public bool IsCastrated { get; private set; }

        public DateOnly Birthday { get; private set; }

        public bool isVaccinated { get; private set; }

        public PetStatus PetStatus { get; private set; }

        public ListRequisites Requisites { get; private set; }

        public DateTime CreationDate { get; private set; }

        public List<PetPhoto> PetPhotos { get; private set; }
    }

    
}
