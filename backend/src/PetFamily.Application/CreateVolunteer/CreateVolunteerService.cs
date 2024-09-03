using PetFamily.Domain.Models.Shared;
using PetFamily.Domain.Models.Volunteer;
using PetFamily.Domain.Models.VolunteerModel;

namespace PetFamily.Application.CreateVolunteer
{
    public class CreateVolunteerService
    {
        private readonly IVolunteersRepositories _volunteersRepositories;

        public CreateVolunteerService(IVolunteersRepositories volunteersRepositories)
        {
            _volunteersRepositories = volunteersRepositories;
        }

        public async Task<Result<Guid>> Create(CreateVolunteerRequest request, CancellationToken cancellationToken)
        {
            var volunteerId = VolunteerId.NewId();

            var socialNetworksSelect = request.SocialNetworks.Select(s => SocialNetwork.Create(s.Name, s.Link));
            
            var socialNetworks = SocialNetworkList.Create(socialNetworksSelect.Select(s => s.Value));

            var requisitesSelect = request.Requisites.Select(r => Requisite.Create(r.Name, r.Description));

            var requisites = RequisiteList.Create(requisitesSelect.Select(r => r.Value));

            var volunteer = new Volunteer
                (
                    volunteerId,
                    request.Name,
                    request.Description,
                    request.Workexp,
                    request.PhoneNumber,
                    socialNetworks,
                    requisites
                );

            await _volunteersRepositories.Add(volunteer, cancellationToken);

            return volunteerId.Value;
        }
    }

}
