using CommonTestUtilities.Requests;
using CommonTestUtilities.Tokens;
using InventoryControl.Communication.Requests;
using InventoryControl.Exceptions;
using Shouldly;
using System.Net;
using System.Text.Json;

namespace WebApi.Test.User.ChangePassword
{
    public class ChangePasswordTest : InventoryControlClassFixture
    {
        private const string METHOD = "user/change-password";

        private readonly string _password;
        private readonly string _email;
        private readonly Guid _userIdentifier;

        public ChangePasswordTest(CustomWebApplicationFactory factory) : base(factory)
        {
            _password = factory.GetPassword();
            _email = factory.GetEmail();
            _userIdentifier = factory.GetUserIdentifier();
        }

        [Fact]
        public async Task Success()
        {
            var token = JwtTokenGeneratorBuilder.Build().Generate(_userIdentifier);

            var request = RequestChangePasswordJsonBuilder.Build();
            request.Password = _password;

            var response = await DoPut(method: METHOD, request: request, token: token);
            response.StatusCode.ShouldBe(HttpStatusCode.NoContent);

            var loginRequest = new RequestLoginJson
            {
                Email = _email,
                Password = _password
            };

            response = await DoPost(method: "login", request: loginRequest);
            response.StatusCode.ShouldBe(HttpStatusCode.Unauthorized);

            loginRequest.Password = request.NewPassword;

            response = await DoPost(method: "login", request: loginRequest);
            response.StatusCode.ShouldBe(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Error_NewPassword_Empty()
        {
            var token = JwtTokenGeneratorBuilder.Build().Generate(_userIdentifier);

            var request = new RequestChangePasswordJson
            {
                Password = _password,
                NewPassword = string.Empty
            };

            var response = await DoPut(method: METHOD, request: request, token: token);

            response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);

            await using var responseBody = await response.Content.ReadAsStreamAsync();

            var responseData = await JsonDocument.ParseAsync(responseBody);

            var errors = responseData.RootElement.GetProperty("errors").EnumerateArray();

            errors.Count().ShouldBe(1);
            errors.ShouldContain(c => c.GetString()!.Equals(ResourceMessagesException.EMPTY_PASSWORD));
        }
    }
}
