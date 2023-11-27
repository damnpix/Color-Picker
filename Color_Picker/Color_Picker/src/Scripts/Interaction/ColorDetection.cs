using System.Drawing;
namespace Color_Picker.Scripts.Interaction
{
    public class ColorDetection
    {
        public static Color DetectColor(Point position)
        {
            using (Bitmap bitmapImage = new Bitmap(1, 1))
            {
                using (Graphics graphics = Graphics.FromImage(bitmapImage))
                {
                    graphics.CopyFromScreen(position, Point.Empty, bitmapImage.Size);      
                }
                return bitmapImage.GetPixel(0, 0);
            }
        }
    }
}