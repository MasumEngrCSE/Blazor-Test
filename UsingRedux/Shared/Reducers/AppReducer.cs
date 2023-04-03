using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingRedux.Shared.Actions;
using UsingRedux.Shared.Stores;

namespace UsingRedux.Shared.Reducers
{
    public static class AppReducer
    {
        [ReducerMethod]
        public static AppStore ReduceIncrementCounterAction
        (AppStore state, IncrementCounterAction action)
        => state with { ClickCounter = state.ClickCounter + 1 };
    }
}
