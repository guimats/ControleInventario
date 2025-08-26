using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;

namespace InventoryControl.Application.UseCases.Token.RefreshToken;

public interface IUseRefreshTokenUseCase
{
    public Task<ResponseTokensJson> Execute(RequestNewTokenJson request);
}
