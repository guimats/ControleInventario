using InventoryControl.Domain.Security.Tokens;

namespace InventoryControl.API.Token
{
    public class HttpContextTokenValue : ITokenProvider
    {
        private readonly IHttpContextAccessor _contextAcessor;

        public HttpContextTokenValue(IHttpContextAccessor contextAcessor)
        {
            _contextAcessor = contextAcessor;
        }

        public string Value()
        {
            var authentication = _contextAcessor.HttpContext!.Request.Headers.Authorization.ToString();

            return authentication["Bearer ".Length..].Trim();
        }
    }
}
