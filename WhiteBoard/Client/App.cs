using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using WhiteBoard.Shared;

namespace WhiteBoard.Client
{
    public partial class App : IAsyncDisposable
    {
        private readonly List<LineSegment> LineSegments= new List<LineSegment>();

        //private Task AddLineSegment(LineSegment segment)
        //{
        //    List<LineSegment> segments =
        //    new List<LineSegment>() { segment };
        //    this.LineSegments.Add(segment);
        //    return Task.CompletedTask;
        //}

        private async Task AddLineSegment(LineSegment segment)
        {
            List<LineSegment> segments =
            new List<LineSegment>() { segment };
            await this.hubConnection.SendAsync("SendSegments", segments);
            this.LineSegments.Add(segment);
        }


        [Inject]
        public NavigationManager navigationManager { get; set; } = default!;
        private HubConnection hubConnection = default!;



        protected override async Task OnInitializedAsync()
        {
            this.hubConnection = new HubConnectionBuilder().WithUrl(navigationManager.ToAbsoluteUri("/board")).Build();
            this.hubConnection.On<IEnumerable<LineSegment>>("AddSegments",
            segments =>
            {
                this.LineSegments.AddRange(segments);
                StateHasChanged();
            });
            this.hubConnection.On<List<LineSegment>>("InitSegments",
            allSegments =>
            {
                this.LineSegments.AddRange(allSegments);
                StateHasChanged();
            });
            await this.hubConnection.StartAsync();
            await this.hubConnection.SendAsync("GetAllSegments");
        }

        public async ValueTask DisposeAsync()
        {
            if (this.hubConnection is not null)
            {
                await this.hubConnection.DisposeAsync();
            }
        }
    }
}
