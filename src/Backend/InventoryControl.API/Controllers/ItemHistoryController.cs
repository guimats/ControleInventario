using InventoryControl.API.Attributes;
using InventoryControl.Application.UseCases.ItemHistory.GetHistory;
using InventoryControl.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace InventoryControl.API.Controllers
{
    [Route("item-history")]
    [ApiController]
    [AuthenticatedUser]
    public class ItemHistoryController : ControllerBase
    {
        [HttpGet]
        [Route("by-item/{id}")]
        [ProducesResponseType(typeof(ResponseItemHistoriesJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetByItemId(
            [FromServices] IGetItemHistoryUseCase useCase,
            [FromRoute] long id)
        {
            var response = await useCase.Execute(id);

            return Ok(response);
        }
    }
}
