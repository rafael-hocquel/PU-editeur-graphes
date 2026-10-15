namespace GraphDrawing
{
    internal class Node : IDeletable
    {
        public bool Deleted { get; set; } = false;
        public Point Location { get; set; }

        public string Text { get; set; } = "";

        public Size Size { get; private set; } = new Size(10, 10);

        public int Width { get; set; } = 2;

        public Color Color { get; set; } = Color.Black;

        public Point Centre => new(Location.X + Size.Width / 2, Location.Y + Size.Height / 2);

        public bool Contains(Point p)
        {
            return new Rectangle(Outils.GeometryToScreen(Location), Outils.GeometryToScreen(Size)).Contains(p);
        }

        public void Draw(Graphics g)
        {
            if (Deleted) return;
            Rectangle r = new(Outils.GeometryToScreen(Location), Outils.GeometryToScreen(Size));
            Pen pen = new Pen(Color, Width);
            Brush brush = new SolidBrush(Color);
            g.DrawRectangle(pen, r);
            g.DrawString(Text, new Font("Times New Roman", 15, FontStyle.Bold), brush, Outils.GeometryToScreen(Location));
        }

        public void Move(Point p) {
            Location = p;
        }
    }
}
