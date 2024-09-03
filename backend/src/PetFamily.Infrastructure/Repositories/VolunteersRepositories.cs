using Microsoft.EntityFrameworkCore;
using PetFamily.Application;
using PetFamily.Domain.Models.Shared;
using PetFamily.Domain.Models.VolunteerModel;

namespace PetFamily.Infrastructure.Repositories
{
    public class VolunteersRepositories : IVolunteersRepositories
    {
        private readonly ApplicationDbContext _dbContext;

        public VolunteersRepositories(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Add(Volunteer volunteer, CancellationToken cancellationToken = default)
        {
            await _dbContext.Volunteers.AddAsync(volunteer, cancellationToken);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return volunteer.Id.Value;
        }

        public async Task<Result<Volunteer>> GetById(VolunteerId volunteerId)
        {
            var volunteer = await _dbContext.Volunteers
                .Include(v => v.Pets)
                .FirstOrDefaultAsync(v => v.Id == volunteerId);

            if(volunteer is null) 
                return "Volunteer not found";

            return volunteer;
            
        }
    }
}
