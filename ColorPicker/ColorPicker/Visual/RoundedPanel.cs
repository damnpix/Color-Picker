using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ColorPicker.Visual
{
    public partial class RoundedPanel : Control
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr roundedPanel(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public int _cornerRadiusX { get; set; }
        public int _cornerRadiusY { get; set; }

        public RoundedPanel()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            IntPtr ptr = roundedPanel(0, 0, Width, Height, _cornerRadiusX, _cornerRadiusY);
            Region = Region.FromHrgn(ptr);
        }
    }
}
