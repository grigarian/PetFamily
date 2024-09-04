using CSharpFunctionalExtensions;
using PetFamily.Domain.Models.Shared;

namespace PetFamily.Domain.Models.PetModel
{
    public record Address
    {
        private Address()
        {
            
        }
        public string City { get; }

        public string Street { get; }

        public string PostalCode { get; }

        public string HouseNumber { get; }

        public string ApartNumber { get; }

        private Address(string city, string street, string postalCode,
            string houseNumber, string apartamentNumber)
        {
            City = city;
            Street = street;
            PostalCode = postalCode;    
            HouseNumber = houseNumber;
            ApartNumber = apartamentNumber;
        }

        public static Result<Address, Error> Create(string city, string street, string postalCode,
            string houseNumber, string apartamentNumber)
        {
            if (string.IsNullOrWhiteSpace(city))
                return Errors.General.ValueIsInvalid("city");

            if (string.IsNullOrWhiteSpace(street))
                return Errors.General.ValueIsInvalid("street");

            if (string.IsNullOrWhiteSpace(postalCode))
                return Errors.General.ValueIsInvalid("postalCode");

            if (string.IsNullOrWhiteSpace(houseNumber))
                return Errors.General.ValueIsInvalid("houseNumber");

            return new Address(city, street, postalCode, houseNumber, apartamentNumber);
        }
    }
}
