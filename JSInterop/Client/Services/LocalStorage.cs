using Microsoft.JSInterop;

namespace JSInterop.Client.Services
{
    public class LocalStorage : ILocalStorage
    {
        private readonly IJSRuntime js;
        public LocalStorage(IJSRuntime js)
        {
            this.js = js;
        }

        public ValueTask<T> GetProperty<T>(string propName)
        => js.InvokeAsync<T>("blazorLocalStorage.get", propName);


        //public ValueTask<T> GetProperty<T>(string propName)
        //{
        //    throw new NotImplementedException();
        //}

        public ValueTask SetProperty<T>(string propName, T value)
        => js.InvokeVoidAsync("blazorLocalStorage.set", propName, value);
        //public ValueTask SetProperty<T>(string propName, T value)
        //{
        //    throw new NotImplementedException();
        //}


        public ValueTask WatchAsync<T>(T instance) where T : class
        => js.InvokeVoidAsync("blazorLocalStorage.watch",
        DotNetObjectReference.Create(instance));

        //public ValueTask WatchAsync<T>(T instance) where T : class
        //{
        //    throw new NotImplementedException();
        //}
    }
}
