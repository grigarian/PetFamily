namespace PetFamily.Application.Volunteers.CreateVolunteer
{
    public record CreateVolunteerRequest
        (
            string Name,
            string Description,
            int Workexp,
            string PhoneNumber,
            List<SocialNetworkDto> SocialNetworks,
            List<RequisiteDto> Requisites
        );

    public record VolunteerDto
        (
           string Name,
            string Description,
            int Workexp,
            string PhoneNumber
        );

    public record SocialNetworkDto(string Name, string Link);

    public record RequisiteDto(string Name, string Description);
}
