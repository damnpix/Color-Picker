using System.Drawing;

namespace ColorPicker.Class
{
    internal class GetColor
    {
        public static Color getColor(Point position)
        {
            using (Bitmap bmp = new Bitmap(1, 1))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.CopyFromScreen(position, Point.Empty, bmp.Size);
                }

                return bmp.GetPixel(0, 0);
            }
        }
    }
}
