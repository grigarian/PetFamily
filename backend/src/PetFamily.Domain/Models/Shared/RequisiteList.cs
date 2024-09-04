using CSharpFunctionalExtensions;

namespace PetFamily.Domain.Models.Shared
{
    public record RequisiteList
    {
        private RequisiteList() {}
        private RequisiteList(IEnumerable<Requisite> requisites) => Requisites = requisites.ToList();
        public IReadOnlyList<Requisite> Requisites { get; }

        public static Result<RequisiteList, Error> Create(IEnumerable<Requisite> socialNetworks)
        {
            return new RequisiteList(socialNetworks);
        }
    }
}
