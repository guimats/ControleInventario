using InventoryControl.API.Attributes;
using InventoryControl.Application.UseCases.Item.Register;
using InventoryControl.Application.UseCases.Item.Update;
using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace InventoryControl.API.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredItemJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
        [AuthenticatedUser]
        public async Task<IActionResult> Register(
            [FromServices] IRegisterItemUseCase useCase,
            [FromBody] RequestRegisterItemJson request)
        {
            var result = await useCase.Execute(request);

            return Created(string.Empty, result);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [AuthenticatedUser]
        public async Task<IActionResult> UpdateItem(
            [FromRoute] long id,
            [FromServices] IUpdateItemUseCase useCase,
            [FromBody] RequestRegisterItemJson request)
        {
            await useCase.Execute(id, request);

            return NoContent();
        }
    }
}
