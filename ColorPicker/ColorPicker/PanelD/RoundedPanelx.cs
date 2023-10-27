using System.Runtime.InteropServices;

namespace ColorPicker.PanelD
{
    public partial class RoundedPanelx : Panel
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr roundedPanel(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public RoundedPanelx()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            IntPtr ptr = roundedPanel(0, 0, Width, Height, 20, 20);
            Region = Region.FromHrgn(ptr);
        }
    }
}
