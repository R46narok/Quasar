using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace Quasar.Hybrid.Shared.Storage
{
    public static class LocalStorage
    {
        private const string SetItemIdentifier = "localStorage.setItem";
        private const string GetItemIdentifier = "localStorage.getItem";
        private const string RemoveItemIdentifier = "localStorage.removeItem";

        public static async Task SetItemAsync<T>(IJSRuntime runtime, string key, T item)
        {
            await runtime.InvokeVoidAsync(SetItemIdentifier, key, item);
        }

        public static async Task<T> GetItemAsync<T>(IJSRuntime runtime, string key)
        {
            return await runtime.InvokeAsync<T>(GetItemIdentifier, key);
        }

        public static async Task RemoveItemAsync<T>(IJSRuntime runtime, string key)
        {
            await runtime.InvokeAsync<T>(RemoveItemIdentifier, key);
        }
    }
}
