using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;
using InventoryControl.Exceptions.ExceptionsBase;
using InventoryControl.UI.WinForms.Providers;
using System.Net;
using System.Net.Http.Json;

namespace InventoryControl.UI.WinForms.Services.Item.Write
{
    public class WriteItemService : IWriteItemService
    {
        private readonly IHttpClientProvider _httpClientProvider;

        public WriteItemService(IHttpClientProvider httpClientProvider)
        {
            _httpClientProvider = httpClientProvider;
        }

        public async Task DeleteItemAsync(long id)
        {
            await _httpClientProvider.DeleteAsync($"item/{id}");
        }

        public async Task<ResponseRegisteredItemJson?> RegisterAsync(RequestItemJson request)
        {
            return await _httpClientProvider.PostAsync<ResponseRegisteredItemJson>("item", request);
        }
    }
}
