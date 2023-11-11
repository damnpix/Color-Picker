using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker.Visual
{
    public partial class RoundedTextBox : TextBox
    {
        public int RoundX { get; set; } = 10;

        public int RoundY { get; set; } = 10;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr roundedPanel(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public RoundedTextBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            IntPtr ptr = roundedPanel(0, 0, Width, Height, RoundX, RoundY);
            Region = Region.FromHrgn(ptr);
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            IntPtr ptr = roundedPanel(0, 0, Width, Height, RoundX, RoundY);
            Region = Region.FromHrgn(ptr);
        }
    }
}
