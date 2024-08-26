﻿using PetFamily.Domain.Models.Shared;

namespace PetFamily.Domain.Models.PetModel
{
    public sealed class Pet : Entity<PetId>
    {
        private Pet(PetId id) : base(id)
        {

        }

        private Pet(PetId petId, string name, string description, string breed, string color, string healthInfo, Address address, double weight, double hight, string phoneNumber,
            bool isCastrated, DateOnly birthday, bool isVaccinated, PetStatus petStatus, Requisites requisite, DateTime creationDate, PetPhotos petPhotos ) : base(petId)
        {
            Name = name;
            Description = description;
            Breed = breed;
            Color = color;
            HealthInfo = healthInfo;
            Address = address;
            Weight = weight;
            Hight = hight;
            PhoneNumber = phoneNumber;
            IsCastrated = isCastrated;
            Birthday = birthday;
            IsVaccinated = isVaccinated;
            PetStatus = petStatus;
            Requisites = requisite;
            CreationDate = creationDate;
            PetPhotos = petPhotos;

        }

        public string Name { get; private set; }

        public string Type { get; private set; }

        public string Description { get; private set; }

        public string Breed { get; private set; }

        public string Color { get; private set; }

        public string HealthInfo { get; private set; }

        public Address Address { get; private set; }

        public double Weight { get; private set; }

        public double Hight { get; private set; }

        public string PhoneNumber { get; private set; }

        public bool IsCastrated { get; private set; }

        public DateOnly Birthday { get; private set; }

        public bool IsVaccinated { get; private set; }

        public PetStatus PetStatus { get; private set; }

        public Requisites Requisites { get; private set; }

        public DateTime CreationDate { get; private set; }

        public PetPhotos PetPhotos { get; private set; }
    }

    
}
