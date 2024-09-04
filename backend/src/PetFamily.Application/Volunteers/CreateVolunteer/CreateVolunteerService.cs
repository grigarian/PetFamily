using CSharpFunctionalExtensions;
using PetFamily.Domain.Models.Shared;
using PetFamily.Domain.Models.Volunteer;
using PetFamily.Domain.Models.VolunteerModel;

namespace PetFamily.Application.Volunteers.CreateVolunteer
{
    public class CreateVolunteerService
    {
        private readonly IVolunteersRepository _volunteersRepository
            ;

        public CreateVolunteerService(IVolunteersRepository volunteersRepository)
        {
            _volunteersRepository = volunteersRepository;
        }

        public async Task<Result<Guid, Error>> Create(CreateVolunteerRequest request, CancellationToken cancellationToken)
        {
            var volunteerId = VolunteerId.NewId();

            var socialNetworksSelect = request.SocialNetworks.Select(s => SocialNetwork.Create(s.Name, s.Link));

            var socialNetworks = SocialNetworkList.Create(socialNetworksSelect.Select(s => s.Value));

            if(socialNetworks.IsFailure)
                return socialNetworks.Error;

            var requisitesSelect = request.Requisites.Select(r => Requisite.Create(r.Name, r.Description));

            var requisites = RequisiteList.Create(requisitesSelect.Select(r => r.Value));

            if (requisites.IsFailure)
                return requisites.Error;

            var volunteer = Volunteer.Create
                (
                    volunteerId,
                    request.Name,
                    request.Description,
                    request.Workexp,
                    request.PhoneNumber,
                    socialNetworks.Value,
                    requisites.Value
                );

            await _volunteersRepository.Add(volunteer.Value, cancellationToken);

            if (volunteer.IsFailure)
                return volunteer.Error;

            return volunteerId.Value;
        }
    }

}
