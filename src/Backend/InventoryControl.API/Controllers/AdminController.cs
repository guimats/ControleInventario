using InventoryControl.API.Attributes;
using InventoryControl.Application.UseCases.Admin.ChangeUserPassword;
using InventoryControl.Communication.Requests;
using Microsoft.AspNetCore.Mvc;

namespace InventoryControl.API.Controllers
{

    [Route("[controller]")]
    [ApiController]
    [AuthenticatedUser]
    public class AdminController : ControllerBase
    {
        [HttpPut("{id}/change-password")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> ChangePassword(
            [FromServices] IChangeUserPasswordUseCase useCase,
            [FromBody] RequestChangePasswordJson request,
            [FromRoute] long id)
        {
            await useCase.Execute(request, id);

            return NoContent();
        }
    }
}
