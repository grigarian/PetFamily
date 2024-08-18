namespace PetFamily.Domain.Models
{
    public class PetPhoto
    {
        public Guid Id { get; private set; }

        public string Path { get; private set; }

        public bool IsHeadPhoto { get; private set; }
    }
}
