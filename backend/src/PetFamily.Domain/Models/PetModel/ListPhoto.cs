namespace PetFamily.Domain.Models.PetModel
{
    public record ListPhoto
    {
        public List<PetPhoto> PetPhotos { get; private set; }
    }
}
