namespace GraphDrawing
{
    internal class Line : IDeletable
    {
        public bool Deleted { get; set; } = false;
        public Node? Start { get; init; }

        public Node? End { get; init; }

        public void Draw (Graphics g)
        {
            if (Deleted) return;
            if(Start == null || End == null) { return;  }
            Pen p = Pens.Black;
            g.DrawLine(p, Outils.GeometryToScreen(Start.Centre), Outils.GeometryToScreen(End.Centre));
        }
    }
}
