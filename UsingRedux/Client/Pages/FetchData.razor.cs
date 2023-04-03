﻿using Fluxor;
using Microsoft.AspNetCore.Components;
using UsingRedux.Shared.Actions;
using UsingRedux.Shared.Stores;

namespace UsingRedux.Client.Pages
{
    public partial class FetchData
    {
        [Inject]
        public IState<AppStore> State { get; set; } = default!;
        [Inject]
        public IDispatcher Dispatcher { get; set; } = default!;
        public AppStore AppStore => State.Value;
        protected override void OnInitialized()
        {
            Dispatcher.Dispatch(new FetchDataAction());
            base.OnInitialized();
        }

    }
}