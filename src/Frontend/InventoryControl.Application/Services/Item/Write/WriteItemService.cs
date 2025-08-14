using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;
using InventoryControl.Exceptions.ExceptionsBase;
using InventoryControl.UI.WinForms.Services.Interfaces.Item;
using InventoryControl.UI.WinForms.Services.Interfaces.User;
using System.Net;
using System.Net.Http.Json;

namespace InventoryControl.UI.Application.Services.Item.Write
{
    public class WriteItemService : IWriteItemService
    {
        private readonly IHttpClientProvider _httpClientProvider;

        public WriteItemService(IHttpClientProvider httpClientProvider)
        {
            _httpClientProvider = httpClientProvider;
        }

        public async Task<bool> DeleteItemAsync(long id)
        {
            var response = await _httpClientProvider.Client.DeleteAsync($"item/{id}");

            if (response.StatusCode == HttpStatusCode.NoContent)
                return true;

            var errors = await response.Content.ReadAsStringAsync();
            throw new Exception(errors);
        }

        public async Task<ResponseRegisteredItemJson?> RegisterAsync(RequestItemJson request)
        {
            var response = await _httpClientProvider.Client.PostAsJsonAsync("item", request);

            if (response.StatusCode is HttpStatusCode.Created)
                return await response.Content.ReadFromJsonAsync<ResponseRegisteredItemJson>();

            var errors = await response.Content.ReadFromJsonAsync<ResponseErrorJson>();

            throw new ErrorOnValidationException(errors!.Errors!);
        }
    }
}
