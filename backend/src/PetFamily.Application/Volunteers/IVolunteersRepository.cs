using PetFamily.Domain.Models.VolunteerModel;

namespace PetFamily.Application.Volunteers
{
    public interface IVolunteersRepository
    {
        Task<Guid> Add(Volunteer volunteer, CancellationToken cancellationToken);
    }
}
