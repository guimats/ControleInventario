using CommonTestUtilities.Requests;
using InventoryControl.Exceptions;
using Shouldly;
using System.Net;
using System.Text.Json;

namespace WebApi.Test.User.Register
{
    public class RegisterUserTest : InventoryControlClassFixture
    {
        private const string METHOD = "user";

        public RegisterUserTest(CustomWebApplicationFactory factory) : base(factory) { }

        [Fact]
        public async Task Success()
        {
            var request = RequestRegisterUserJsonBuilder.Build();

            // enviando request para a API 
            var response = await DoPost(method: METHOD, request: request);

            response.StatusCode.ShouldBe(HttpStatusCode.Created);

            // recuperando os dados da response e pegando o body
            await using var responseBody = await response.Content.ReadAsStreamAsync();

            // tratando dados para JSON
            var responseData = await JsonDocument.ParseAsync(responseBody);

            responseData.RootElement.GetProperty("name").GetString().ShouldSatisfyAllConditions(
                response => response.ShouldNotBeNull(),
                response => response.ShouldBe(request.Name));

            responseData.RootElement.GetProperty("tokens").GetProperty("accessToken").GetString().ShouldNotBeNullOrEmpty();
        }

        [Fact]
        public async Task Error_Empty_Name()
        {
            var request = RequestRegisterUserJsonBuilder.Build();
            request.Name = string.Empty;

            var response = await DoPost(method: METHOD, request: request);

            response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);

            await using var responseBody = await response.Content.ReadAsStreamAsync();

            var responseData = await JsonDocument.ParseAsync(responseBody);

            var errors = responseData.RootElement.GetProperty("errors").EnumerateArray();

            errors.ShouldSatisfyAllConditions(
                errors => errors.Count().ShouldBe(1),
                errors => errors.ShouldContain(e => e.GetString()!.Equals(ResourceMessagesException.EMPTY_NAME)));
        }
    }
}
