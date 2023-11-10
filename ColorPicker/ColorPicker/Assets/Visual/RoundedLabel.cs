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
    public partial class RoundedLabel : Label
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr roundedPanel(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public int _cornerRadiusX { get; set; } = 15;
        public int _cornerRadiusY { get; set; } = 15;

        public RoundedLabel()
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
