namespace CamShot
{
    using System.Drawing;
    
    public static class Capture
    {
        public static Bitmap Screenshot;
        public static void GetImage(Image src, Point point, Size size)
        {
            Screenshot = new Bitmap(size.Width, size.Height);
            using (var g = Graphics.FromImage(Screenshot))
            {
                g.DrawImage(src, new Rectangle(new Point(0, 0), size), new Rectangle(point, size), GraphicsUnit.Pixel);
            }
        }

    }
}
