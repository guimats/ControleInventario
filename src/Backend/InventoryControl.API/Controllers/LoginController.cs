using InventoryControl.Application.UseCases.Login.DoLogin;
using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace InventoryControl.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Login(
            [FromServices] IDoLoginUseCase useCase,
            [FromBody] RequestLoginJson request)
        {
            var result = await useCase.Execute(request);
            return Ok(result);
        }
    }
}
