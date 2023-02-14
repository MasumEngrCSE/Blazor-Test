using Microsoft.AspNetCore.Components;

namespace Blazor_Test.Pages
{
    public partial class DismissibleAlert
    {
        [Parameter]
        public bool Show { get; set; }
        [Parameter]
        public RenderFragment ChildContent { get; set; } = default!;
        public void Dismiss()
        => Show = false;
    }
}
