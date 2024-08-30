namespace PetFamily.Domain.Models.Shared
{
    public record RequisiteList
    {
        private RequisiteList() {}
        private RequisiteList(ICollection<Requisite> requisites) => Requisites = requisites.ToList();
        public IReadOnlyList<Requisite> Requisites { get; }
    }
}
