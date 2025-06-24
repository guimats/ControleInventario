using InventoryControl.Communication.Responses;
using InventoryControl.Domain.Repositories.User;
using InventoryControl.Domain.Security.Tokens;
using InventoryControl.Exceptions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using InventoryControl.Exceptions.ExceptionsBase;

namespace InventoryControl.API.Filters
{
    public class AuthenticatedUserFilter : IAsyncAuthorizationFilter
    {
        private readonly IAccessTokenValidator _accessTokenValidator;
        private readonly IUserReadOnlyRepository _repository;

        public AuthenticatedUserFilter(IAccessTokenValidator accessTokenValidator, IUserReadOnlyRepository repository)
        {
            _accessTokenValidator = accessTokenValidator;
            _repository = repository;
        }

        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            try
            {
                var token = TokenOnRequest(context);

                var userIdentifier = _accessTokenValidator.ValidateAndGetUserIdentifier(token);

                var exist = await _repository.ExistActiveUserWithIdentifier(userIdentifier);
                if (!exist)
                {
                    throw new InventoryControlException(ResourceMessagesException.USER_WITHOUT_PERMISSION_ACCESS_RESOURCE);
                }
            }
            catch (SecurityTokenExpiredException)
            {
                context.Result = new UnauthorizedObjectResult(new ResponseErrorJson("TokeIsExpired")
                {
                    TokenIsExpired = true,
                });
            }
            catch (InventoryControlException ex)
            {
                context.Result = new UnauthorizedObjectResult(new ResponseErrorJson(ex.Message));
            }
            catch
            {
                context.Result = new UnauthorizedObjectResult(new ResponseErrorJson(ResourceMessagesException.USER_WITHOUT_PERMISSION_ACCESS_RESOURCE));
            }
        }

        private static string TokenOnRequest(AuthorizationFilterContext context)
        {
            var authentication = context.HttpContext.Request.Headers.Authorization.ToString();

            if (string.IsNullOrEmpty(authentication))
            {
                throw new InventoryControlException(ResourceMessagesException.NO_TOKEN);
            }

            // mesmo que fazer -> authentication[7..].Trim()
            // o retorno da authorization na request vai conter esse Bearer, por isso removemos
            return authentication["Bearer ".Length..].Trim();
        }
    }
}
