namespace PetFamily.Domain.Models.Shared
{
    public abstract class Entity<Tid> where Tid : notnull
    {
        protected Entity(Tid id) 
        {
            Id = id;
        }
        public Tid Id { get; private set; }
    }
}
