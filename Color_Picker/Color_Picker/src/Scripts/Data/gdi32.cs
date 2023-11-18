using System;
using System.Runtime.InteropServices;
namespace Color_Picker.Scripts.Data
{
    public class gdi32
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CornerRadius(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
    }
}