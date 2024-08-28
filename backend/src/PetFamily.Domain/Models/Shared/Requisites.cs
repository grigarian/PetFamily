namespace PetFamily.Domain.Models.Shared
{
    public record Requisites
    {
        private Requisites() {}
        private Requisites(ICollection<Requisite> requisites) => Requisite = requisites.ToList();
        public IReadOnlyList<Requisite> Requisite { get; }
        public static Requisites Create(ICollection<Requisite> requisites) => new(requisites);
    }
}
