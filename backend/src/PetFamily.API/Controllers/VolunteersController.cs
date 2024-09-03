using Microsoft.AspNetCore.Mvc;
using PetFamily.Application.CreateVolunteer;

namespace PetFamily.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VolunteersController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<Guid>> Create(
            [FromServices] CreateVolunteerService service,
            [FromBody] CreateVolunteerRequest request,
            CancellationToken cancellationToken)
        {
            var result = await service.Create(request, cancellationToken);

            if(result.IsFailure)
            {
                return BadRequest(result.Error);
            }

            return Ok(result.Value);
        }
    }
}

