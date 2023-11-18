using System;
using System.Runtime.InteropServices;

namespace Color_Picker.Scripts.Data
{
    public class user32
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
    }
}