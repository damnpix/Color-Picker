using ColorPicker.Assets.Pinvoke;
using ColorPicker.Class;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class DefaultScreen : Form
    {
        public static bool _buttonIsPressed;

        public DefaultScreen()
        {
            InitializeComponent();
            roundedButton4.MouseEnter += (sender, e) => { roundedButton4.BackColor = Color.FromArgb(39, 39, 39); };
            roundedButton4.MouseLeave += (sender, e) => { roundedButton4.BackColor = Color.FromArgb(32, 32, 32); };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread bck = new Thread(BackgroundThread)
            { IsBackground = true };
            bck.Start();
        }
        void BackgroundThread()
        {
            while (true)
            {
                if (_buttonIsPressed)
                {
                    roundedPanel2.BackColor = GetColor.getColor(Cursor.Position);
                    roundedLabel1.Text = ColorTranslator.ToHtml(GetColor.getColor(Cursor.Position));
                }
            }
        }
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Cross;
            _buttonIsPressed = true;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            _buttonIsPressed = false;
            Cursor = Cursors.Default;
        }

        private async void roundedButton2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(roundedLabel1.Text);
            roundedButton2.Image = Properties.Resources.success20x20;
            await Task.Delay(1500);
            roundedButton2.Image =  Properties.Resources.copy20x20;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            IntPtr ptr = importPinvoke.roundedCorners(0, 0, Width, Height, importPinvoke._cornerRadiusX, importPinvoke._cornerRadiusY);
            Region = Region.FromHrgn(ptr);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                importPinvoke.ReleaseCapture();
                importPinvoke.SendMessage(Handle, importPinvoke.WM_NCLBUTTONDOWN, importPinvoke.HT_CAPTION, 0);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
            if(TopMost) roundedButton3.Image = Properties.Resources.unpin20x20;
            else roundedButton3.Image = Properties.Resources.pin20x20;
        }
    }
}
