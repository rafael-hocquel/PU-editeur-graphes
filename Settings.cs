

namespace GraphDrawing
{
    internal class Settings
    {
        public static float Zoom { get; set; } = 1.0f;

        public static int BaseNodeWidth { get; set; } = 2;
        public static Color BaseNodeColor { get; set; } = Color.Black;

        public static Point Origin { get; set; } = new(0, 0);
    }
}
