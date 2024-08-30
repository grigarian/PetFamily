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

        public static Result<Address> Create(string city, string street, string postalCode,
            string houseNumber, string apartamentNumber)
        {
            if (string.IsNullOrWhiteSpace(city))
                return "City is invalir or empty";

            if (string.IsNullOrWhiteSpace(street))
                return "Street is invalir or empty";

            if (string.IsNullOrWhiteSpace(postalCode))
                return "PostalCode is invalir or empty";

            if (string.IsNullOrWhiteSpace(houseNumber))
                return "HouseNumber is invalir or empty";

            return new Address(city, street, postalCode, houseNumber, apartamentNumber);
        }
    }
}
