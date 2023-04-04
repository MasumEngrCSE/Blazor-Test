//using System;
//using System.Collections.Generic;
using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace WhiteBoard.Shared
{
    public struct LineSegment
    {
        public LineSegment(PointF start, PointF end)
        {
            Start = start;
            End = end;
        }
        public PointF Start { get; set; }
        public PointF End { get; set; }
    }
}
