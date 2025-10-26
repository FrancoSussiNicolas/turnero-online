using Microsoft.JSInterop;

namespace BlazorApp.Client.Services
{
    public class LocalStorageService
    {
        private readonly IJSRuntime js;

        public LocalStorageService(IJSRuntime js)
        {
            this.js = js;
        }

        public async Task SetItemAsync(string key, string value)
        {
            await js.InvokeVoidAsync("localStorage.setItem", key, value);
        }

        public async Task<string?> GetItemAsync(string key)
        {
            return await js.InvokeAsync<string>("localStorage.getItem", key);
        }

        public async Task RemoveItemAsync(string key)
        {
            await js.InvokeVoidAsync("localStorage.removeItem", key);
        }
    }
}
