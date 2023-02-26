using Microsoft.AspNetCore.Components;

namespace Components.Advanced.Pages
{
    public partial class Grid<TItem>
    {
        [Parameter]
        public RenderFragment Header { get; set; } = default!;
        [Parameter]
        public RenderFragment<TItem> Row { get; set; } = default!;
        [Parameter]
        public RenderFragment Footer { get; set; } = default!;
        [Parameter]
        public IReadOnlyList<TItem> Items { get; set; } = default!;
    }

    public class DisposableList<T> where T : IDisposable
    {

    }
}
