using WhiteBoard.Shared;

namespace WhiteBoard.Client
{
    public partial class App
    {
        private readonly List<LineSegment> LineSegments= new List<LineSegment>();

        private Task AddLineSegment(LineSegment segment)
        {
            List<LineSegment> segments =
            new List<LineSegment>() { segment };
            this.LineSegments.Add(segment);
            return Task.CompletedTask;
        }





    }
}
