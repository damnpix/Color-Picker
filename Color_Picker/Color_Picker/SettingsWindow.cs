using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Color_Picker.Scripts.Data;

namespace Color_Picker
{
    public partial class SettingsWindow : Form
    {
        
        public enum DWMWINDOWATTRIBUTE
        {
            DWMWA_WINDOW_CORNER_PREFERENCE = 33
        }
        
        public enum DWM_WINDOW_CORNER_PREFERENCE
        {
            DWMWCP_DEFAULT      = 0,
            DWMWCP_DONOTROUND   = 1,
            DWMWCP_ROUND        = 2,
            DWMWCP_ROUNDSMALL   = 3
        }
        
        [DllImport("dwmapi.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
        internal static extern void DwmSetWindowAttribute(IntPtr hwnd,
            DWMWINDOWATTRIBUTE attribute, 
            ref DWM_WINDOW_CORNER_PREFERENCE pvAttribute, 
            uint cbAttribute);


        public SettingsWindow()
        {
            InitializeComponent();
            
            var attribute = DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE;
            var preference = DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUND;
            DwmSetWindowAttribute(this.Handle, attribute, ref preference, sizeof(uint));
            
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

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            binaryWriter.SettingsWrite(checkBox1.Checked,checkBox2.Checked);
            Close();
        }
    }
}