using InventoryControl.API.Attributes;
using InventoryControl.Application.UseCases.Item.Delete;
using InventoryControl.Application.UseCases.Item.Filter;
using InventoryControl.Application.UseCases.Item.GetById;
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
            [FromBody] RequestItemJson request)
        {
            var result = await useCase.Execute(request);

            return Created(string.Empty, result);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [AuthenticatedUser]
        public async Task<IActionResult> UpdateItem(
            [FromRoute] long id,
            [FromServices] IUpdateItemUseCase useCase,
            [FromBody] RequestItemJson request)
        {
            await useCase.Execute(id, request);

            return NoContent();
        }

        [HttpPost("filter")]
        [ProducesResponseType(typeof(ResponseItensJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Filter(
            [FromServices] IFilterItensUseCase useCase,
            [FromBody] RequestFilterItemJson request)
        {
            var response = await useCase.Execute(request);

            if (response.Itens.Any())
                return Ok(response);

            return NoContent();
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponseItemJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(
            [FromServices] IGetItemByIdUseCase useCase,
            [FromRoute] long id)
        {
            var response = await useCase.Execute(id);

            return Ok(response);
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(
            [FromServices] IDeleteItemUseCase useCase,
            [FromRoute] long id)
        {
            await useCase.Execute(id);

            return NoContent();
        }
    }
}
