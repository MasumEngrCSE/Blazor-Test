using Microsoft.JSInterop;

namespace JSInterop.Client.Services
{
    public class LocalStorageWithModule : ILocalStorage
    {
        private readonly IJSRuntime js;
        private IJSObjectReference? module;
        public LocalStorageWithModule(IJSRuntime js)
        {
            this.js = js;
        }

        public ValueTask<T> GetProperty<T>(string propName)
        => js.InvokeAsync<T>("blazorLocalStorage.get", propName);

        public async ValueTask Init()
        {
            module = module ?? await js.InvokeAsync<IJSObjectReference>
            ("import", "./scripts/localstorage.js");
        }
        //public ValueTask Init() => new ValueTask();




        public ValueTask SetProperty<T>(string propName, T value)
        => js.InvokeVoidAsync("blazorLocalStorage.set", propName, value);


        public ValueTask WatchAsync<T>(T instance) where T : class
        => js.InvokeVoidAsync("blazorLocalStorage.watch",
        DotNetObjectReference.Create(instance));


    }
}
