using Microsoft.AspNetCore.Components;

namespace Blazor_Test.Pages
{
    public partial class LifeCycle
    {
        public LifeCycle()
        {
            Console.WriteLine("Inside constructor");
        }
        private int counter;
        [Parameter]
        public int Counter
        {
            get => counter;
            set
            {
                counter = value;
                Console.WriteLine($"Counter set to {counter}");
            }
        }
        public override Task SetParametersAsync(ParameterView parameters)
        {
            Console.WriteLine("SetParametersAsync called");
            return base.SetParametersAsync(parameters);
        }

        protected override void OnParametersSet()=> Console.WriteLine("OnParametersSet called");

        protected override void OnInitialized() => Console.WriteLine("OnInitialized called");
        protected override void OnAfterRender(bool firstRender) => Console.WriteLine($"OnAfterRender called with firstRender ={firstRender}");
        protected override bool ShouldRender()
        {
            Console.WriteLine($"ShouldRender called");
            return true;
        }
        public void Dispose() => Console.WriteLine("Disposed");




    }
}
