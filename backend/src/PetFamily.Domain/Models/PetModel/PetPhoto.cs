namespace PetFamily.Domain.Models.PetModel
{
    public class PetPhoto
    {
        public Guid Id { get; private set; }

        public string Path { get; private set; }

        public bool IsMainPhoto { get; private set; }
    }
}
