using System;
using System.Runtime.InteropServices;

namespace ColorPicker.Assets.Pinvoke
{
    internal class importPinvoke
    {
        //set form position
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //rounded corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr roundedCorners(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public static int _cornerRadiusX { get; set; } = 10;
        public static int _cornerRadiusY { get; set; } = 10;

    }
}
