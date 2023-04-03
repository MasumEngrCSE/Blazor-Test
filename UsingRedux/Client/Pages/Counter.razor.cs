using Fluxor;
using Microsoft.AspNetCore.Components;
using UsingRedux.Shared.Stores;




namespace UsingRedux.Client.Pages
{
    public partial class Counter
    {
        [Inject]
        public IState<AppStore> State { get; set; } = default!;
        public AppStore AppStore => State.Value;
    }
}