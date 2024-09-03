using PetFamily.Domain.Models.VolunteerModel;

namespace PetFamily.Application
{
    public interface IVolunteersRepositories
    {
        Task<Guid> Add(Volunteer volunteer, CancellationToken cancellationToken);
    }
}
