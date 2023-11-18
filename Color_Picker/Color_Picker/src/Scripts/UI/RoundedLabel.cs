using System.Windows.Forms;
using Color_Picker.Scripts.Data;
using System;
using System.Drawing;

namespace Color_Picker.Scripts.UI
{
    public partial class RoundedLabel : Label
    {
        public int cornerRadiusX { get; set; } = 10;
        public int cornerRadiusY { get; set; } = 10;
        
        public RoundedLabel()
        {
            InitializeComponent();
            BackColor = ColorPalette.buttonBackgroundColor();
            ForeColor = ColorPalette.foregroundColor();
            TextAlign = ContentAlignment.MiddleCenter;
        }
        
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            IntPtr ptr = gdi32.CornerRadius(1, 1, Width, Height, cornerRadiusX, cornerRadiusY);
            Region = Region.FromHrgn(ptr);
        }
    }
}