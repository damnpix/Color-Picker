using System;
using System.Drawing;
using System.Windows.Forms;
using Color_Picker.Scripts.Data;

namespace Color_Picker
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
            roundedButton3.MouseEnter += (sender, e) => { roundedButton3.BackColor = Color.FromArgb(39, 39, 39); };
            roundedButton3.MouseLeave += (sender, e) => { roundedButton3.BackColor = Color.FromArgb(20, 20, 20); };
            panel1.MouseDown += HeaderMove;

            checkBox1.Checked = binaryReader.topMost;
            checkBox2.Checked = binaryReader.optimize;
        }
        
        void HeaderMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                const int WM_NCLBUTTONDOWN = 0xA1;
                const int HT_CAPTION = 0x2;
                user32.ReleaseCapture();
                user32.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            IntPtr ptr = gdi32.CornerRadius(0, 0, Width, Height, 10, 10);
            Region = Region.FromHrgn(ptr);
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            binaryWriter.SettingsWrite(checkBox1.Checked,checkBox2.Checked);
            Close();
        }
    }
}