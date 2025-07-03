using CommonTestUtilities.Requests;
using CommonTestUtilities.Tokens;
using Shouldly;
using System.Net;

namespace WebApi.Test.User.ChangePassword
{
    public class ChangePasswordInvalidTokenTest : InventoryControlClassFixture
    {
        private const string METHOD = "user/change-password";

        public ChangePasswordInvalidTokenTest(CustomWebApplicationFactory factory) : base(factory) { }

        [Fact]
        public async Task Error_Invalid_Token()
        {
            var request = RequestChangePasswordJsonBuilder.Build();

            var response = await DoPut(method: METHOD, request: request, token: "invalidToken");

            response.StatusCode.ShouldBe(HttpStatusCode.Unauthorized);
        }

        [Fact]
        public async Task Error_Without_Token()
        {
            var request = RequestChangePasswordJsonBuilder.Build();

            var response = await DoPut(method: METHOD, request: request, token: string.Empty);

            response.StatusCode.ShouldBe(HttpStatusCode.Unauthorized);
        }

        [Fact]
        public async Task Error_Token_With_User_NotFound()
        {
            var request = RequestChangePasswordJsonBuilder.Build();

            var token = JwtTokenGeneratorBuilder.Build().Generate(Guid.NewGuid());

            var response = await DoPut(method: METHOD, request: request, token: token);

            response.StatusCode.ShouldBe(HttpStatusCode.Unauthorized);
        }
    }
}
