namespace PetFamily.Domain.Models.Shared
{
    public record Requisite
    {
        public string Name { get; }

        public string Description { get; }

        private Requisite(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public static Result<Requisite> Create (string name, string description)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length > Constants.MAX_LOW_TEXT_LENGHT)
                return "Name is invalid or empty";
            if (string.IsNullOrWhiteSpace(description) || description.Length > Constants.MAX_HIGH_TEXT_LENGHT)
                return "Description invalid or empty";

            return new Requisite(name, description);
        }
    }
}
