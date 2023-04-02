using Fluxor;
using Microsoft.AspNetCore.Components;
using UsingRedux.Shared.Stores;

public partial class Counter
{
    [Inject]
    public IState<AppStore> State { get; set; } = default!;
    public AppStore AppStore => State.Value;
}