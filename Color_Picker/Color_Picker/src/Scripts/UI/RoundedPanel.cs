using System.Windows.Forms;
using Color_Picker.Scripts.Data;
using System;
using System.Drawing;

namespace Color_Picker.Scripts.UI
{
    public partial class RoundedPanel : Panel
    {
        public int cornerRadiusX { get; set; } = 10;
        public int cornerRadiusY { get; set; } = 10;
        
        public RoundedPanel()
        {
            InitializeComponent();
        }
        
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            IntPtr ptr = gdi32.CornerRadius(0, 0, Width, Height, cornerRadiusX, cornerRadiusY);
            Region = Region.FromHrgn(ptr);
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            IntPtr ptr = gdi32.CornerRadius(0, 0, Width, Height, cornerRadiusX, cornerRadiusY);
            Region = Region.FromHrgn(ptr);
        }
    }
}