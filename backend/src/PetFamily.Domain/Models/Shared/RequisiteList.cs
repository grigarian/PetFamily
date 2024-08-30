namespace PetFamily.Domain.Models.Shared
{
    public record RequisiteList
    {
        private RequisiteList() {}
        private RequisiteList(IEnumerable<Requisite> requisites) => Requisites = requisites.ToList();
        public IReadOnlyList<Requisite> Requisites { get; }
    }
}
