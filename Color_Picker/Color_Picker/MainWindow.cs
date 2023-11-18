using System;
using System.Drawing;
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
        
        public MainWindow()
        {
            InitializeComponent();
            
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
                Clipboard.SetText(roundedLabel2.Text);
                roundedButton2.Image = Resources.done;
                roundedButton2.Enabled = false;
                roundedButton2.BackColor = Color.Green;
                await Task.Delay(1500);
                roundedButton2.Enabled = true;
                roundedButton2.BackColor = ColorPalette.accentColor();
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
                    roundedPanel1.BackColor = ColorDetection.DetectColor(Cursor.Position);
                    roundedLabel2.Text = ColorTranslator.ToHtml(ColorDetection.DetectColor(Cursor.Position));
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
        
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            IntPtr ptr = gdi32.CornerRadius(0, 0, Width, Height, 10, 10);
            Region = Region.FromHrgn(ptr);
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