using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color_Picker.Properties;
using Color_Picker.Scripts.Data;
using Color_Picker.Scripts.UI;
using System.Threading;
using Color_Picker.Scripts.Interaction;

namespace Color_Picker
{
    public partial class MainWindow : Form
    {
        private static bool buttonPressed = false;

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
        
        public MainWindow()
        {
            InitializeComponent();
            
            var attribute = DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE;
            var preference = DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUND;
            DwmSetWindowAttribute(this.Handle, attribute, ref preference, sizeof(uint));
            
            roundedButton3.MouseEnter += (sender, e) => { roundedButton3.BackColor = Color.FromArgb(39, 39, 39); };
            roundedButton3.MouseLeave += (sender, e) => { roundedButton3.BackColor = Color.FromArgb(20, 20, 20); }; 
            roundedButton4.MouseEnter += (sender, e) => { roundedButton4.BackColor = Color.FromArgb(39, 39, 39); };
            roundedButton4.MouseLeave += (sender, e) => { roundedButton4.BackColor = Color.FromArgb(20, 20, 20); };
            
            panel1.MouseDown += HeaderMove;
            
            roundedButton1.MouseDown += (sender, e) =>
            {
                Cursor = new Cursor(Resources.selectCur.GetHicon());
                buttonPressed = true;
            };

            roundedButton1.MouseUp += (sender, e) =>
            {
                buttonPressed = false;
                Cursor = Cursors.Default;
            };

            roundedButton2.Click += async (sender, e) =>
            {
                Clipboard.SetText(roundedLabel1.Text);
                roundedButton2.Image = Resources.done;
                roundedButton2.Enabled = false;
                roundedButton2.BackColor = Color.Green;
                roundedButton2.BorderColor = ColorTranslator.FromHtml("#00ad00");
                await Task.Delay(1500);
                roundedButton2.Enabled = true;
                roundedButton2.BackColor = ColorPalette.accentColor();
                roundedButton2.BorderColor = Color.FromArgb(7, 95, 190);
                roundedButton2.Image = Resources.copy;
            };
            CheckForIllegalCrossThreadCalls = false;
            Thread bck = new Thread(BackgroundThread) { IsBackground = true };
            bck.Start();
        }

        async void BackgroundThread()
        {
            while (true)
            {
                binaryReader.SettingsRead();
                TopMost = binaryReader.topMost;
                if (buttonPressed)
                {
                    roundedPanel2.BackColor = ColorDetection.DetectColor(Cursor.Position);
                    roundedLabel1.Text = ColorTranslator.ToHtml(ColorDetection.DetectColor(Cursor.Position));
                    roundedPanel2.BorderColor = ColorDetection.DetectColor(Cursor.Position);
                    if (binaryReader.optimize) await Task.Delay(50);
                }
                await Task.Delay(5);
            }
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
            Application.Exit();
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            new SettingsWindow().ShowDialog();
        }
    }
}